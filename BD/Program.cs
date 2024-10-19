using BD.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Настройки подключения к базе данных
        string? connection = builder.Configuration.GetConnectionString("DefaultConnection1");
        if (connection == null)
        {
            throw new InvalidOperationException("Строка подключения 'DefaultConnection1' не найдена.");
        }
        builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));
        builder.Services.AddRazorPages();

        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => options.LoginPath = "/login");

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            context.Database.Migrate();
        }

        app.UseDefaultFiles();
        app.UseStaticFiles();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapRazorPages();

        // Регистрация
        app.MapPost("/register", async (User user, ApplicationContext context) =>
        {
            var errors = new List<string>();

            // Проверка имени пользователя
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                errors.Add("Введите имя пользователя");
            }
            else
            {
                if (user.Username.Contains(" "))
                {
                    errors.Add("Имя пользователя не должно содержать пробелов");
                }
                if (!Regex.IsMatch(user.Username, @"^[a-zA-Z0-9]+$"))
                {
                    errors.Add("Имя пользователя должно содержать только буквы и цифры");
                }
                if (user.Username.Length < 3)
                {
                    errors.Add("Имя пользователя должно содержать не менее 3 символов");
                }
            }

            // Проверка на существование пользователя
            if (await context.Users.AnyAsync(u => u.Username == user.Username))
            {
                errors.Add("Пользователь с таким именем уже зарегистрирован.");
            }

            // Проверка пароля
            if (string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                errors.Add("Введите пароль");
            }
            else
            {
                if (user.PasswordHash.Length < 8)
                {
                    errors.Add("Пароль должен содержать не менее 8 символов");
                }
                if (!user.PasswordHash.Any(char.IsDigit))
                {
                    errors.Add("Пароль должен содержать хотя бы одну цифру");
                }
                if (!user.PasswordHash.Any(char.IsLetter))
                {
                    errors.Add("Пароль должен содержать хотя бы одну букву");
                }
                if (!user.PasswordHash.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    errors.Add("Пароль должен содержать хотя бы один спецсимвол");
                }
            }

            // Проверка совпадения паролей
            if (string.IsNullOrWhiteSpace(user.ConfirmPassword) || user.PasswordHash != user.ConfirmPassword)
            {
                errors.Add("Пароли не совпадают!");
            }

            if (errors.Count > 0)
            {
                return Results.BadRequest(new { errors });
            }

            user.PasswordHash = User.HashPassword(user.PasswordHash);

            try
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return Results.Json(new { errors = new List<string> { "Ошибка сервера: " + ex.Message } }, statusCode: 500);
            }

            return Results.Redirect("/login");
        });

        // Вход
        app.MapPost("/login", async (User loginUser, ApplicationContext context, HttpContext httpContext) =>
        {
            var errors = new List<string>();

            try
            {
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(loginUser.Username))
                {
                    errors.Add("Введите имя пользователя");
                }

                if (string.IsNullOrWhiteSpace(loginUser.PasswordHash))
                {
                    errors.Add("Введите пароль");
                }

                if (errors.Count > 0)
                {
                    return Results.BadRequest(new { errors });
                }

                // Поиск пользователя в базе данных
                var user = await context.Users.FirstOrDefaultAsync(u => u.Username == loginUser.Username);

                // Проверка правильности пароля
                if (user == null || !user.VerifyPassword(loginUser.PasswordHash))
                {
                    errors.Add("Неверное имя пользователя или пароль");
                    return Results.BadRequest(new { errors });
                }

                var claims = new List<Claim> { new Claim(ClaimTypes.Name, user.Username) };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return Results.Redirect("/");
            }
            catch (Exception ex)
            {
                return Results.Json(new { errors = new List<string> { "Ошибка сервера: " + ex.Message } }, statusCode: 500);
            }
        });

        app.MapGet("/api/user", (HttpContext httpContext) =>
        {
            var user = httpContext.User.Identity?.Name;

            if (user != null)
            {
                return Results.Ok(new { username = user });
            }

            return Results.Ok(new { username = (string?)null });
        });

        app.MapPost("/logout", async (HttpContext httpContext) =>
        {
            await httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Results.Ok();
        });

        app.Run();
    }
}
