using Ekos.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ekos.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class TerminalController : ControllerBase
{
    private readonly TerminalService _terminalService;

    public TerminalController(TerminalService terminalService)
    {
        _terminalService = terminalService;
    }

    [HttpGet("info")]
    public IActionResult GetInfo()
    {
        var userAgent = Request.Headers["User-Agent"];
        var ip = HttpContext.Connection.RemoteIpAddress?.ToString();

        var result = _terminalService.GetTerminalInfo(userAgent, ip);
        
        return Ok(result);
    }
}