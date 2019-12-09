using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileError.Model.Model;

namespace CompileError.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Purchase> Purchases { set; get; }
        public DbSet<PurchasedProduct> PurchasedProducts { set; get; }
        public DbSet<Sale> Sales { set; get; }
        public DbSet<SalesDetail> SalesDetails { set; get; }
    }
}
