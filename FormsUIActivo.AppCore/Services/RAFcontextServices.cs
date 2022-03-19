using FormsUIActivo.AppCore.IContracts;
using FormsUIActivo.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUIActivo.AppCore.Services
{
    public abstract class RAFcontextServices<T> : IColeccionServices<T> where T : class
    {
        private IColeccion<T> coleccion;

        public RAFcontextServices(IColeccion<T> coleccion)
        {
            this.coleccion = coleccion;
        }

        #region CRUD

        public void Add(T t)
        {
            coleccion.Add(t);
        }

        public bool Delete(T t)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<T> GetAll()
        {
            return coleccion.GetAll();  
        }

        public bool Update(T t)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
