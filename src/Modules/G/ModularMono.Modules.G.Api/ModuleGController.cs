using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMono.Modules.G.Api;

[ApiController]
[Route("[controller]")]
public sealed class ModuleGController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
        => Ok("Hello from Module G!");
}
