using BD.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string? connection = builder.Configuration.GetConnectionString("DefaultConnection1");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));

builder.Services.AddRazorPages();

var app = builder.Build();

using(var scope = builder.Services.BuildServiceProvider().CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
	context.Database.Migrate();
}

app.MapRazorPages();
app.UseStaticFiles();
app.Run();
