using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class AccountConfiguration: EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            HasMany(a => a.Messages).WithRequired(b => b.To).HasForeignKey(c => c.AccountToID);
        }
    }
}
