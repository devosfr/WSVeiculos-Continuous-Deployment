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
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
                
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

     
    }
}
