using InternalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternalManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly ILogger<ClientController> _logger;
    private readonly IClientService _clientService;
    public ClientController(ILogger<ClientController> logger, IClientService clientService)
    {
        _logger = logger;
        _clientService = clientService;
    }

    [HttpGet()]
    public async Task<IActionResult> Get()
    {
        try
        {
            return Ok(await _clientService.GetClients());
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet("/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            return Ok(await _clientService.GetClientById(id));
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpPost("/new-client")]
    public async Task<IActionResult> CreateNewClient([FromBody] Client client)
    {
        try
        {
            await _clientService.CreateNewClient(client);
            return StatusCode(200);   
        }
        catch
        {
            return StatusCode(400);
        }
    }
    [HttpPut("/update-client")]
    public async Task<IActionResult> UpdateClient([FromBody] Client client)
    {
        try
        {
            await _clientService.UpdateClient(client);
            return StatusCode(200);
        }
        catch
        {
            return StatusCode(400);
        }
    }

    [HttpDelete("/{id}")]
    public async Task<IActionResult> DeleteClient(int id)
    {
        try
        {
            await _clientService.DeleteClient(id);
            return StatusCode(200);
        }
        catch
        {
            return StatusCode(400);
        }
    }
}
