namespace Locadão.Application.dtos;

public class ClienteDTO
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public required string Endereco { get; set; }
    public bool Cnh { get; set; }
    public required List<VeiculoDTO> Veiculos { get; set; }
}

