using Data.Infrastructure;
using Domain.Entities;
using Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AccountService : ServicePattern<Account>
    {
        private static IDataBaseFactory dbf = new DataBaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public AccountService() : base(ut)
        {

        }
    }
}
