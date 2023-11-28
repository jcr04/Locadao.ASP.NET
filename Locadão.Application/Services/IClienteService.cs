using Locadão.Application.dtos;

namespace Locadão.Application.Services;

public interface IClienteService
{
    ClienteDTO GetClienteById(int id);
    IEnumerable<ClienteDTO> GetAllClientes();
    void AddCliente(ClienteDTO clienteDto);
    void UpdateCliente(ClienteDTO clienteDto);
    void DeleteCliente(int id);
}

