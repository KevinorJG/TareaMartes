using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUIActivo.Domain.Contracts
{
    public interface IColeccion <T>
    {
        /// CRUD
        void Add(T t);
        bool Update(T t);
        bool Delete(T t);   
        IReadOnlyList<T> GetAll();
    }
}
