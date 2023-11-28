using Locadão.Application.dtos;
using Locadão.Domain.entitys;
using Locadão.Infrastructure.Repositories;

namespace Locadão.Application.Services;

    public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public ClienteDTO GetClienteById(int id)
    {
        var cliente = _clienteRepository.GetById(id);
        if (cliente == null) return null;

        return new ClienteDTO
        {
            // Mapear as propriedades do cliente para ClienteDTO
        };
    }

    public IEnumerable<ClienteDTO> GetAllClientes()
    {
        var clientes = _clienteRepository.GetAll();
        return clientes.Select(c => new ClienteDTO
        {
            // Mapear as propriedades de cada cliente para ClienteDTO
        }).ToList();
    }

    public void AddCliente(ClienteDTO clienteDto)
    {
        var cliente = new Cliente(
            clienteDto.Nome,
            clienteDto.Cpf,
            clienteDto.DataNascimento,
            clienteDto.Endereco,
            clienteDto.Cnh
        );

        _clienteRepository.Add(cliente);
    }


    public void UpdateCliente(ClienteDTO clienteDto)
    {
        var cliente = _clienteRepository.GetById(clienteDto.Id);
        if (cliente == null) return;

        // Atualizar as propriedades do cliente
        // cliente.Nome = clienteDto.Nome, etc.

        _clienteRepository.Update(cliente);
    }

    public void DeleteCliente(int id)
    {
        var cliente = _clienteRepository.GetById(id);
        if (cliente == null) return;

        _clienteRepository.Delete(cliente);
    }
}

