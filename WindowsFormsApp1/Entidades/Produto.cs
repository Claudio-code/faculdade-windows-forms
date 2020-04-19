using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Produto() { }
        public Produto(string descricao, decimal valor)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Valor = valor;
        }
    }
}
