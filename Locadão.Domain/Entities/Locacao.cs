using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadão.Domain.entitys;

public class Locacao
{
    public int Id { get; set; }
    public int VeiculoId { get; set; }
    public Veiculo Veiculo { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public double ValorTotal { get; set; }

    // Construtor
    public Locacao(int veiculoId, DateTime dataInicio, DateTime dataFim, double valorTotal)
    {
        VeiculoId = veiculoId;
        DataInicio = dataInicio;
        DataFim = dataFim;
        ValorTotal = valorTotal;
    }

    public void ValidarDataInicio()
    {
        if (DataInicio < DateTime.Today)
        {
            throw new Exception("A data de início da locação não pode ser uma data passada.");
        }
    }

}

