using Buzz.Jewelcrafting.Services;
using Microsoft.AspNetCore.Mvc;

namespace Buzz.Jewelcrafting.Controllers;

public class DesignsController : ApiController
{
    private readonly DesignService _designService;

    public DesignsController(DesignService designService)
    {
        _designService = designService;
    }
    [HttpGet]
    public async Task<IActionResult> GetSummary()
    {
        return Ok(await _designService.GetDesignStatusSummary());
    }
}