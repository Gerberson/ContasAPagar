using System;

namespace ContasAPagar.Domain.Entities
{
    public class Despesa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataRegistro { get; set; }
        public bool Pago { get; set; }
        public Usuario Usuario { get; set; }

        public Despesa(string descricao, decimal valor, DateTime dataVencimento, bool pago, Usuario usuario)
        {
            Descricao = descricao;
            Valor = valor;
            DataVencimento = dataVencimento;
            DataRegistro = DateTime.Now;
            Pago = pago;
            Usuario = usuario;
        }


    }
}