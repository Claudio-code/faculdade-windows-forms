using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    public interface IRepositorioProduto<T>
    {
        void Add(T entidade);
        void Remove(T entidade);
        void Update(T entidade);
        ICollection<T> GetAll();
    }
}
