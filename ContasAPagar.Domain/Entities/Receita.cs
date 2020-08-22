using System;

namespace ContasAPagar.Domain.Entities
{
    public class Receita
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataRecebimento { get; set; }
        public DateTime DataRegistro { get; set; }
        public bool Recebido { get; set; }
        public Usuario Usuario { get; set; }

        public Receita(string descricao, decimal valor, DateTime dataRecebimento, bool recebido, Usuario usuario)
        {
            Descricao = descricao;
            Valor = valor;
            DataRecebimento = dataRecebimento;
            DataRegistro = DateTime.Now;
            Recebido = recebido;
            Usuario = usuario;
        }
    }
}