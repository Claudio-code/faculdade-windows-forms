using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp1.Interfaces;
using WindowsFormsApp1.Entidades;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Repositorios
{
    class RepositorioProduto : IRepositorioProduto<Produto>
    {
        private List<Produto> _produtos = new List<Produto>();

        public void Add(Produto entidade) => _produtos.Add(entidade);

        public ICollection<Produto> GetAll() => _produtos;

        public void Remove(Produto entidade) => _produtos.Remove(entidade);

        public void Update(Produto entidade)
        {
            var registro = GetAll().FirstOrDefault(x => x.Id.Equals(entidade.Id)) ?? new Produto();
            if (string.IsNullOrWhiteSpace(registro.Descricao))
                return;

            Remove(registro);
            Add(entidade);
        }
    }
}
