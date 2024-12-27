using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMono.Modules.E.Api;

[ApiController]
[Route("[controller]")]
public sealed class ModuleEController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
        => Ok("Hello from Module E!");
}
