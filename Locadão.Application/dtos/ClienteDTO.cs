namespace Locadão.Application.dtos;

public class ClienteDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Endereco { get; set; }


    public bool Cnh { get; set; }
}
