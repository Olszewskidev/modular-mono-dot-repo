using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMono.Modules.D.Api;

[ApiController]
[Route("[controller]")]
public sealed class ModuleDController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
        => Ok("Hello from Module D!");
}
