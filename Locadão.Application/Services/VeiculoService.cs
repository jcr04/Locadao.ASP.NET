using Locadão.Application.dtos;
using Locadão.Domain.Entities;
using Locadão.Infrastructure.Repositories;
using System.Linq;

namespace Locadão.Application.Services;

public class VeiculoService : IVeiculoService
{
    private readonly IVeiculoRepository _veiculoRepository;

    public VeiculoService(IVeiculoRepository veiculoRepository)
    {
        _veiculoRepository = veiculoRepository;
    }

    public VeiculoDTO GetVeiculoById(int id)
    {
        var veiculo = _veiculoRepository.GetById(id);
        if (veiculo == null) return null;

        return new VeiculoDTO
        {
            Marca = veiculo.Marca,
            Modelo = veiculo.Modelo,
            Placa = veiculo.Placa,
            Ano = veiculo.Ano,
            PrecoDiaria = veiculo.PrecoDiaria,
            Alugado = veiculo.Alugado,
            // Mapear Locações se necessário
        };
    }

    public IEnumerable<VeiculoDTO> GetAllVeiculos()
    {
        var veiculos = _veiculoRepository.GetAll();
        return veiculos.Select(v => new VeiculoDTO
        {
            Marca = v.Marca,
            Modelo = v.Modelo,
            Placa = v.Placa,
            Ano = v.Ano,
            PrecoDiaria = v.PrecoDiaria,
            Alugado = v.Alugado,
            // Mapear Locações se necessário
        }).ToList();
    }

    public void AddVeiculo(VeiculoDTO veiculoDto)
    {
        var veiculo = new Veiculo(
            veiculoDto.Marca,
            veiculoDto.Modelo,
            veiculoDto.Placa,
            veiculoDto.Ano,
            veiculoDto.PrecoDiaria,
            veiculoDto.Alugado,
            veiculoDto.ClienteId
        );

        if (veiculoDto.Locacoes != null)
        {
            foreach (var locacaoDto in veiculoDto.Locacoes)
            {
                veiculo.Locacoes.Add(new Locacao(
                    veiculo.Id,
                    locacaoDto.DataInicio,
                    locacaoDto.DataFim,
                    locacaoDto.ValorTotal
                ));
            }
        }

        _veiculoRepository.Add(veiculo);
    }



    public void UpdateVeiculo(VeiculoDTO veiculoDto)
    {
        var veiculo = _veiculoRepository.GetById(veiculoDto.Id);
        if (veiculo == null) return;

        // Atualizar propriedades do veículo
        veiculo.Marca = veiculoDto.Marca;
        veiculo.Modelo = veiculoDto.Modelo;
        veiculo.Placa = veiculoDto.Placa;
        veiculo.Ano = veiculoDto.Ano;
        veiculo.PrecoDiaria = veiculoDto.PrecoDiaria;
        veiculo.Alugado = veiculoDto.Alugado;

        _veiculoRepository.Update(veiculo);
    }

    public void DeleteVeiculo(int id)
    {
        var veiculo = _veiculoRepository.GetById(id);
        if (veiculo == null) return;

        _veiculoRepository.Delete(veiculo);
    }
}
