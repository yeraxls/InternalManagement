using InternalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternalManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class InvoiceController : ControllerBase
{
    private readonly ILogger<InvoiceController> _logger;
    private readonly IInvoiceService _invoiceService;
    public InvoiceController(ILogger<InvoiceController> logger, IInvoiceService invoiceService)
    {
        _logger = logger;
        _invoiceService = invoiceService;
    }

    [HttpGet()]
    public async Task<IActionResult> Get()
    {
        try
        {
            return Ok(await _invoiceService.GetInvoices());
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
            return Ok(await _invoiceService.GetInvoiceById(id));
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet("/{idClient}")]
    public async Task<IActionResult> GetInvoiceByIdClient(int idClient)
    {
        return Ok(await _invoiceService.GetInvoicesByIdClient(idClient));
    }

    [HttpPost("/new-invoice")]
    public async Task<IActionResult> CreateNewInvoice([FromBody] Invoice invoice)
    {
        try
        {
            await _invoiceService.CreateNewInvoice(invoice);
            return StatusCode(200);
            
        }
        catch
        {
            return StatusCode(400);
        }
    }

    [HttpPut("/update-invoice")]
    public async Task<IActionResult> UpdateInvoice([FromBody] Invoice invoice)
    {
        try
        {
            await _invoiceService.UpdateInvoice(invoice);
            return StatusCode(200);
            
        }
        catch
        {
            return StatusCode(400);
        }
    }

    [HttpDelete("/{id}")]
    public async Task<IActionResult> DeleteInvoice(int id)
    {
        try
        {
            await _invoiceService.DeleteInvoice(id);
            return StatusCode(200);
            
        }
        catch
        {
            return StatusCode(400);
        }
    }
}
