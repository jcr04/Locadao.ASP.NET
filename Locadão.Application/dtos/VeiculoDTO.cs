namespace Locadão.Application.dtos;

public class VeiculoDTO
{
    public int Id { get; set; }
    public required string Marca { get; set; }
    public required string Modelo { get; set; }
    public required string Placa { get; set; }
    public int Ano { get; set; }
    public double PrecoDiaria { get; set; }
    public bool Alugado { get; set; }
    public List<LocacaoDTO>? Locacoes { get; set; }
}

