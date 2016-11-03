using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Context : DbContext
    {
        public Context()
            : base("Name=MyDBFilm")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add();
        }
        public DbSet<> A { get; set; }
        public DbSet<> B { get; set; }
    }
    
    public class MyFinanceContextInitialize : DropCreateDatabaseIfModelChanges<Context>
    {

        protected override void Seed(Context context) {
            var maList = new List<Category>()
            {
                new Category()
                {
                    Name="Cosmétique"
                },
                new Category()
                {
                    Name="Meuble"
                }
            };
            context.Categories.AddRange(maList);
            context.SaveChanges();
          
        }
    }
}
