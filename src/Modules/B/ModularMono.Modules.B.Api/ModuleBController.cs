using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModularMono.Modules.B.Api;

[ApiController]
[Route("[controller]")]
public sealed class ModuleBController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
    => Ok("Hello from Module B!");
}
