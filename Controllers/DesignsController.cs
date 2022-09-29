using System.Security.Claims;
using Buzz.Jewelcrafting.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Buzz.Jewelcrafting.Utilities.UserDesignStatus;

namespace Buzz.Jewelcrafting.Controllers;

public class DesignsController : ApiController
{
    private readonly DesignService _designService;
    private readonly UserActionService _userActionService;

    public DesignsController(DesignService designService, UserActionService userActionService)
    {
        _designService = designService;
        _userActionService = userActionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetSummary()
    {
        return Ok(await _designService.GetDesignStatusSummary());
    }

    [HttpPatch("{id}")]
    [Authorize]
    public async Task<IActionResult> ChangeDesignStatus(int id, [FromQuery] string status)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        switch (status)
        {
            case Owned:
                await _userActionService.SetAsOwned(userId, id);
                return NoContent();
            case Pending:
                await _userActionService.SetAsPending(userId, id);
                return NoContent();
            case Unowned:
                await _userActionService.SetAsUnowned(userId, id);
                return NoContent();
            default:
                throw new ArgumentException("Unknown status type, can not execute endpoint", nameof(status));
        }
    }
}