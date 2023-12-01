using Locadão.Application.dtos;
using Locadão.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadão.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClientesController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ClienteDTO>> GetAllClientes()
    {
        var clientes = _clienteService.GetAllClientes();
        return Ok(clientes);
    }

    [HttpGet("{id}")]
    public ActionResult<ClienteDTO> GetClienteById(int id)
    {
        var cliente = _clienteService.GetClienteById(id);
        if (cliente == null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }

    [HttpPost]
    public ActionResult AddCliente([FromBody] ClienteDTO clienteDto)
    {
        _clienteService.AddCliente(clienteDto);
        return CreatedAtAction(nameof(GetClienteById), new { id = clienteDto.Id }, clienteDto);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateCliente(int id, [FromBody] ClienteDTO clienteDto)
    {
        if (id != clienteDto.Id)
        {
            return BadRequest();
        }

        _clienteService.UpdateCliente(clienteDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCliente(int id)
    {
        _clienteService.DeleteCliente(id);
        return NoContent();
    }
}
