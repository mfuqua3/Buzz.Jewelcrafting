using Microsoft.AspNetCore.Mvc;

namespace Buzz.Jewelcrafting.Controllers;

[ApiController]
[Area("api")]
[Route("[area]/[controller]")]
public abstract class ApiController : Controller
{
}