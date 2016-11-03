using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class ServicePattern<T> : IServicePattern<T> where T : class
    {

        IUnitOfWork uok;
        public ServicePattern(IUnitOfWork uok)
        {
            this.uok = uok;
        }
        public void Add(T entity)
        {
            uok.getRepository<T>().Add(entity);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            uok.getRepository<T>().Delete(where);
        }

        public void Delete(T entity)
        {
            uok.getRepository<T>().Delete(entity);
        }

        public void Dispose()
        {
            uok.Dispose();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
           return uok.getRepository<T>().Get(where);
        }

        public IEnumerable<T> GetAll()
        {
           return uok.getRepository<T>().GetAll();
        }

        public T GetById(string Id)
        {
            return uok.getRepository<T>().GetById(Id);
        }

        public T GetById(long Id)
        {
            return uok.getRepository<T>().GetById(Id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return uok.getRepository<T>().GetMany(where);
        }

        public void Update(T entity)
        {
            uok.getRepository<T>().Update(entity);
        }
    }
}
