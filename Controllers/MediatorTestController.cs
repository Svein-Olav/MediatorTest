using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Mediator.Controllers;

[ApiController]
[Route("[controller]")]
public class MediatorTestController : ControllerBase
{
    
    private readonly IMediator _mediator;

    private readonly ILogger<MediatorTestController> _logger;

    public MediatorTestController(ILogger<MediatorTestController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetPing")]
    public async Task<string> Get()
    {
        return await _mediator.Send(new Ping());
    }
}
