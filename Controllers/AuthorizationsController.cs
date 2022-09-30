using AspNet.Security.OAuth.Discord;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Buzz.Jewelcrafting.Controllers;

[Route("~/authorize")]
public class AuthorizationsController : ApiController
{
    [HttpGet]
    public IActionResult AuthorizeAsync([FromQuery] string redirectUrl)
    {
        var authenticationProperties = new AuthenticationProperties
        {
            RedirectUri = redirectUrl
        };
        return Challenge(authenticationProperties, DiscordAuthenticationDefaults.AuthenticationScheme);
    }
}