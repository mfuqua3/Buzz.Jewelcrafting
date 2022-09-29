using Buzz.Jewelcrafting.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Buzz.Jewelcrafting.Controllers;

public class TestController : ApiController
{
    
    [HttpGet, Authorize]
    public IActionResult Test()
    {
        return Ok();
    }
}