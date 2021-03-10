using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ECommerceContext:DbContext
    {
        public ECommerceContext()
        {
            Database.Connection.ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=ECommerceDb;Trusted_Connection=True;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
