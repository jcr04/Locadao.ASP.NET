using Locadão.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Locadão.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }
        private string _nome;

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome não pode ser vazio ou nulo.");
                _nome = value;
            }
        }

        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public bool Cnh { get; set; }
        public List<Veiculo> Veiculos { get; private set; }

        public Cliente(string nome, string cpf, DateTime dataNascimento, string endereco, bool cnh)
        {
            _nome = nome ?? throw new ArgumentException("O nome não pode ser nulo.");
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Cnh = cnh;
            Veiculos = new List<Veiculo>();
        }

        // Métodos de validação ou regras de negócio...
    }
}
