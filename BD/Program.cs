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

        // ��������� ����������� � ���� ������
        string? connection = builder.Configuration.GetConnectionString("DefaultConnection1");
        if (connection == null)
        {
            throw new InvalidOperationException("������ ����������� 'DefaultConnection1' �� �������.");
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

        // �����������
        app.MapPost("/register", async (User user, ApplicationContext context) =>
        {
            var errors = new List<string>();

            // �������� ����� ������������
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                errors.Add("������� ��� ������������");
            }
            else
            {
                if (user.Username.Contains(" "))
                {
                    errors.Add("��� ������������ �� ������ ��������� ��������");
                }
                if (!Regex.IsMatch(user.Username, @"^[a-zA-Z0-9]+$"))
                {
                    errors.Add("��� ������������ ������ ��������� ������ ����� � �����");
                }
                if (user.Username.Length < 3)
                {
                    errors.Add("��� ������������ ������ ��������� �� ����� 3 ��������");
                }
            }

            // �������� �� ������������� ������������
            if (await context.Users.AnyAsync(u => u.Username == user.Username))
            {
                errors.Add("������������ � ����� ������ ��� ���������������.");
            }

            // �������� ������
            if (string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                errors.Add("������� ������");
            }
            else
            {
                if (user.PasswordHash.Length < 8)
                {
                    errors.Add("������ ������ ��������� �� ����� 8 ��������");
                }
                if (!user.PasswordHash.Any(char.IsDigit))
                {
                    errors.Add("������ ������ ��������� ���� �� ���� �����");
                }
                if (!user.PasswordHash.Any(char.IsLetter))
                {
                    errors.Add("������ ������ ��������� ���� �� ���� �����");
                }
                if (!user.PasswordHash.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    errors.Add("������ ������ ��������� ���� �� ���� ����������");
                }
            }

            // �������� ���������� �������
            if (string.IsNullOrWhiteSpace(user.ConfirmPassword) || user.PasswordHash != user.ConfirmPassword)
            {
                errors.Add("������ �� ���������!");
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
                return Results.Json(new { errors = new List<string> { "������ �������: " + ex.Message } }, statusCode: 500);
            }

            return Results.Redirect("/login");
        });

        // ����
        app.MapPost("/login", async (User loginUser, ApplicationContext context, HttpContext httpContext) =>
        {
            var errors = new List<string>();

            try
            {
                // �������� �� ������ ����
                if (string.IsNullOrWhiteSpace(loginUser.Username))
                {
                    errors.Add("������� ��� ������������");
                }

                if (string.IsNullOrWhiteSpace(loginUser.PasswordHash))
                {
                    errors.Add("������� ������");
                }

                if (errors.Count > 0)
                {
                    return Results.BadRequest(new { errors });
                }

                // ����� ������������ � ���� ������
                var user = await context.Users.FirstOrDefaultAsync(u => u.Username == loginUser.Username);

                // �������� ������������ ������
                if (user == null || !user.VerifyPassword(loginUser.PasswordHash))
                {
                    errors.Add("�������� ��� ������������ ��� ������");
                    return Results.BadRequest(new { errors });
                }

                var claims = new List<Claim> { new Claim(ClaimTypes.Name, user.Username) };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return Results.Redirect("/");
            }
            catch (Exception ex)
            {
                return Results.Json(new { errors = new List<string> { "������ �������: " + ex.Message } }, statusCode: 500);
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
