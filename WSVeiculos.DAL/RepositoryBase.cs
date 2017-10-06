using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSVeiculos.DAL.Interfaces;

namespace WSVeiculos.DAL
{
    public class RepositoryBase<TEntity> : Context, IRepositoryBase<TEntity> where TEntity : class
    {
        protected Context db = new Context();

        public void Add(TEntity obj)
        {
            //LimparParametros();
            //AdicionarParametros("@Nome", obj);
                
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public string BuscarPorNome(string Nome)
        {
            return null;
        }
    }
}
