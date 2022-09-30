using System.Security.Claims;
using Buzz.Jewelcrafting.Data;
using Buzz.Jewelcrafting.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Buzz.Jewelcrafting.Controllers;

[Authorize]
public class UsersController : ApiController
{
    private readonly BuzzDbContext _dbContext;

    public UsersController(BuzzDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("me")]
    public async Task<IActionResult> Me()
        => Ok(await _dbContext.Users
            .Where(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier))
            .Select(x => new UserModel { Id = x.Id, Username = x.Name })
            .SingleAsync());
}