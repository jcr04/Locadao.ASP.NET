using Locadão.Application.dtos;

namespace Locadão.Application.Services;

public class ClienteService : IClienteService
{
    // Aqui, você injetará seu repositório ou contexto do banco de dados para operações de CRUD

    public ClienteDTO GetClienteById(int id)
    {
        // Implementação para buscar um cliente
    }

    public IEnumerable<ClienteDTO> GetAllClientes()
    {
        // Implementação para buscar todos os clientes
    }

    public void AddCliente(ClienteDTO clienteDto)
    {
        // Implementação para adicionar um novo cliente
    }

    public void UpdateCliente(ClienteDTO clienteDto)
    {
        // Implementação para atualizar um cliente
    }

    public void DeleteCliente(int id)
    {
        // Implementação para deletar um cliente
    }
}

