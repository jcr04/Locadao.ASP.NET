using Locadão.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadão.Domain.entitys;

public class Veiculo
{
    public required int Id { get; set; }
    public required string Marca { get; set; }
    public required string Modelo { get; set; }
    public required string Placa { get; set; }
    public required int Ano { get; set; }
    public required double PrecoDiaria { get; set; }
    public required bool Alugado { get; set; }

    public required int ClienteId { get; set; }
    public required Cliente Cliente { get; set; }

    public required List<Locacao> Locacoes { get; set; }

    // Construtor
    public Veiculo(string marca, string modelo, string placa, int ano, double precoDiaria)
    {
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Ano = ano;
        PrecoDiaria = precoDiaria;
    }

    // Métodos de validação ou regras de negócio
}

