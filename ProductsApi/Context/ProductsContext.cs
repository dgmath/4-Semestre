using Microsoft.EntityFrameworkCore;
using ProductsApi.Domains;

namespace ProductsApi.Context
{
    public class ProductsContext : DbContext
    {
        public DbSet<Products> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SUPORTE\\SQLEXPRESS; Database=ProductsDB; User Id = sa; Pwd = Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
