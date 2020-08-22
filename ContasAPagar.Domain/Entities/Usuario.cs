using System;
using System.Collections.Generic;

namespace ContasAPagar.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public DateTime DataDeCadastro  { get; set; }
        public List<Receita> Receitas { get; set; }
        public List<Despesa> Despesas { get; set; }
    }

    
}