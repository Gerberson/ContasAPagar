using System;
using System.Collections.Generic;

namespace ContasAPagar.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataDeCadastro  { get; private set; }
        public List<Receita> Receitas { get; private set; }
        public List<Despesa> Despesas { get; private set; }

        public Usuario(string name, string email, DateTime dataNascimento, string senha, DateTime dataDeCadastro)
        {
            Name = name;
            Email = email;
            DataNascimento = dataNascimento;
            Senha = senha;
            DataDeCadastro = dataDeCadastro;
        }
    }
}