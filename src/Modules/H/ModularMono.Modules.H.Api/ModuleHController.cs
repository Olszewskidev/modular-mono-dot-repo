using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMono.Modules.H.Api;

[ApiController]
[Route("[controller]")]
public sealed class ModuleHController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
        => Ok("Hello from Module H!");
}
