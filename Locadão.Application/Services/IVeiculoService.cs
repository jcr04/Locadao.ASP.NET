using Locadão.Application.dtos;

namespace Locadão.Application.Services;

public interface IVeiculoService
{
    VeiculoDTO GetVeiculoById(int id);
    IEnumerable<VeiculoDTO> GetAllVeiculos();
    void AddVeiculo(VeiculoDTO veiculoDto);
    void UpdateVeiculo(VeiculoDTO veiculoDto);
    void DeleteVeiculo(int id);
}
