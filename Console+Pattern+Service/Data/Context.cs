using Data.Configurations;
using Domain.Entities;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext
    {
        public Context()
            : base("Name=MyDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Message>()
                .HasRequired(a => a.From).WithMany(b => b.MessagesSent).HasForeignKey(c => c.AccountFromID);
            modelBuilder.Entity<Message>()
                .HasRequired(a => a.To).WithMany(b => b.MessagesRecieved).HasForeignKey(c => c.AccountToID);
            //modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Properties<int>()
                .Where(p => p.Name.EndsWith("ID"))
                .Configure(p => p.IsKey());
        }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Item> Items { get; set; }
    }
    
    
}
