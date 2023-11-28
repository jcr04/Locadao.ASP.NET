using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadão.Domain.entitys;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Endereco { get; set; }
    public bool Cnh { get; set; }

    public List<Veiculo> Veiculos { get; set; }

    // Construtor
    public Cliente(string nome, string cpf, DateTime dataNascimento, string endereco, bool cnh)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Endereco = endereco;
        Cnh = cnh;
    }

    // Métodos de validação ou regras de negócio
}

