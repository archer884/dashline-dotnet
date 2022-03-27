using Dashline.Core.Context;
using Dashline.Core.Entity;
using Dashline.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace Dashline.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PilotController : ControllerBase
{
    private readonly ILogger<PilotController> _logger;
    private readonly ApplicationContext _context;

    public PilotController(ILogger<PilotController> logger, ApplicationContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost(Name = "CreatePilot")]
    public async Task<Pilot> Post([FromBody] CreatePilot create)
    {
        var pilot = create.AsPilot();
        _context.Pilots.Add(pilot);
        await _context.SaveChangesAsync();
        _logger.LogDebug("Created pilot {pilot}", pilot.Name);
        return pilot;
    }
}
