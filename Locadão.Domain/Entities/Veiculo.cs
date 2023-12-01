namespace Locadão.Domain.Entities;

public class Veiculo
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public int Ano { get; set; }
    public double PrecoDiaria { get; set; }
    public bool Alugado { get; set; }

    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    public List<Locacao> Locacoes { get; set; } = new List<Locacao>();

    public Veiculo(string marca, string modelo, string placa, int ano, double precoDiaria, bool alugado, int clienteId)
    {
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Ano = ano;
        PrecoDiaria = precoDiaria;
        Alugado = alugado;
        ClienteId = clienteId;
    }
}
