using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMono.Modules.I.Api;

[ApiController]
[Route("[controller]")]
public sealed class ModuleIController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
        => Ok("Hello from Module I!");
}
