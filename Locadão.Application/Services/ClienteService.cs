using Locadão.Application.dtos;
using Locadão.Domain.Entities;
using Locadão.Infrastructure.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Text.RegularExpressions;

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
            Nome = cliente.Nome,
            Cpf = cliente.Cpf,
            DataNascimento = cliente.DataNascimento,
            Endereco = cliente.Endereco,
            Cnh = cliente.Cnh,
            Veiculos = cliente.Veiculos.Select(v => new VeiculoDTO
            {
                Marca = v.Marca,
                Modelo = v.Modelo,
                Placa = v.Placa,
                Ano = v.Ano,
                PrecoDiaria = v.PrecoDiaria,
                Alugado = v.Alugado,
                Locacoes = v.Locacoes.Select(l => new LocacaoDTO
                {
                    Id = l.Id,
                    VeiculoId = l.VeiculoId,
                    DataInicio = l.DataInicio,
                    DataFim = l.DataFim,
                    ValorTotal = l.ValorTotal
                }).ToList()
            }).ToList()
        };
    }

    public IEnumerable<ClienteDTO> GetAllClientes()
    {
        var clientes = _clienteRepository.GetAll();
        return clientes.Select(c => new ClienteDTO
        {
            Nome = c.Nome,
            Cpf = c.Cpf,
            DataNascimento = c.DataNascimento,
            Endereco = c.Endereco,
            Cnh = c.Cnh,
            Veiculos = c.Veiculos.Select(v => new VeiculoDTO
            {
                Marca = v.Marca,
                Modelo = v.Modelo,
                Placa = v.Placa,
                Ano = v.Ano,
                PrecoDiaria = v.PrecoDiaria,
                Alugado = v.Alugado,
                Locacoes = v.Locacoes.Select(l => new LocacaoDTO
                {
                    Id = l.Id,
                    VeiculoId = l.VeiculoId,
                    DataInicio = l.DataInicio,
                    DataFim = l.DataFim,
                    ValorTotal = l.ValorTotal
                }).ToList()
            }).ToList()
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

        _clienteRepository.Update(cliente);
    }

    public void DeleteCliente(int id)
    {
        var cliente = _clienteRepository.GetById(id);
        if (cliente == null) return;

        _clienteRepository.Delete(cliente);
    }
}

