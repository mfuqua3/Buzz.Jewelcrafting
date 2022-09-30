using System.Security.Claims;
using AspNet.Security.OAuth.Discord;
using Buzz.Jewelcrafting.Data;
using Buzz.Jewelcrafting.Data.Entities;
using Buzz.Jewelcrafting.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;

namespace Buzz.Jewelcrafting;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        var discordOptions = _configuration.GetSection("Discord")
            .Get<DiscordAuthenticationOptions>();
        services.AddHealthChecks();
        services.AddAuthorization();
        services.AddControllers();
        services.AddAuthentication(opt => { opt.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme; })
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
        services.AddDbContext<BuzzDbContext>(opt =>
        {
            opt.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        });

        services
            .AddScoped<UserActionService>()
            .AddScoped<DesignService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedProto
        });
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseCookiePolicy(new CookiePolicyOptions
        {
            Secure = CookieSecurePolicy.Always
        });
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
        app.UseEndpoints(ep =>
        {
            ep.MapHealthChecks("/health");
            ep.MapControllers();
            ep.MapFallbackToFile("index.html");
        });
    }
}