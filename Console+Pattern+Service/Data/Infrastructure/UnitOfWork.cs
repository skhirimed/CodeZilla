using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private Context dataContext;
        IDataBaseFactory dbFactory;

        public UnitOfWork(IDataBaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
            this.dataContext = dbFactory.DataContext;
        }

        public void commit()
        {
            dataContext.SaveChanges();
        }

        public void Dispose()
        {
            dataContext.Dispose();
        }

        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            IRepositoryBase<T> MyRepo = new RepositoryBase<T>(dataContext); 
            return MyRepo;
        }
    }
}
