using System.Security.Claims;
using AspNet.Security.OAuth.Discord;
using Buzz.Jewelcrafting.Data;
using Buzz.Jewelcrafting.Data.Entities;
using Buzz.Jewelcrafting.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((ctx, lc) => { lc.ReadFrom.Configuration(ctx.Configuration); });
// Add services to the container.
var config = builder.Configuration;
var discordOptions = config.GetSection("Discord")
    .Get<DiscordAuthenticationOptions>();
var services = builder.Services;
services.AddHealthChecks();
services.AddAuthorization();
services.AddControllers();
services.AddAuthentication(opt =>
    {
        opt.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddDiscord(opt =>
    {
        opt.ClientId = discordOptions.ClientId;
        opt.ClientSecret = discordOptions.ClientSecret;
        opt.SaveTokens = true;
        opt.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, opt =>
    {
        opt.Cookie.IsEssential = true;
        opt.Cookie.Name = "Buzz.Jewelcrafting.Application";
        opt.Events.OnRedirectToLogin = context =>
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return Task.CompletedTask;
        };
        opt.Events.OnSigningIn = async context =>
        {
            var userId = context.Principal.FindFirstValue(ClaimTypes.NameIdentifier);
            var username = context.Principal.FindFirstValue(ClaimTypes.Name);
            var database = context.HttpContext.RequestServices.GetRequiredService<BuzzDbContext>();
            var userExists = await database.Users.AnyAsync(x => x.Id == userId);
            if (userExists) return;
            await database.Users.AddAsync(new BuzzUser { Id = userId, Name = username });
            await database.SaveChangesAsync();
        };
    });
services.AddDbContext<BuzzDbContext>(opt => { opt.UseNpgsql(config.GetConnectionString("DefaultConnection")); });

services
    .AddScoped<UserActionService>()
    .AddScoped<DesignService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors(opt =>
{
    opt
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()
        .SetIsOriginAllowed(origin => origin.ToLower().Contains("localhost") || 
                                      origin.ToLower().StartsWith("https://buzz-jewelcrafting.herokuapp.com/"));
});

app.MapHealthChecks("/health");
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();