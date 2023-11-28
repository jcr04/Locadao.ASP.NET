namespace Locadão.Application.dtos;

public class LocacaoDTO
{
    public int Id { get; set; }
    public int VeiculoId { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public double ValorTotal { get; set; }
}

