using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Product.Data
{
   public class ProductDbContext : DbContext
    {
        public DbSet<Product.Domain.Models.Product> Products { get; set; }

        //public ProductDbContext() :base("connectionStr")
        //{

        //}
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyAllConfigurations<ProductDbContext>();
        }

        public override int SaveChanges()
        {
            this.AddAuditInfo();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {           
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
