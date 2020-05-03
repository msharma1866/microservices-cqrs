namespace Product.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Product.Data.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Product.Data.ProductDbContext context)
        {         
            context.Products.AddOrUpdate(new Product.Domain.Models.Product
            {

                ProductId = Guid.NewGuid(),
                ProductName = "Dairy Product",
                ProductCategory = "Dairy",
                ProductTransport = "Full Load",
                IsProductPerishable = true,
                Notes = "Fragile item"
            });
            context.Products.AddOrUpdate(new Product.Domain.Models.Product
            {

                ProductId = Guid.NewGuid(),
                ProductName = "Automobile Product",
                ProductCategory = "Car Engile",
                ProductTransport = "Full Load",
                IsProductPerishable = false,
                Notes = "Heavy item"
            });
            context.Products.AddOrUpdate(new Product.Domain.Models.Product
            {

                ProductId = Guid.NewGuid(),
                ProductName = "Home Decor Product",
                ProductCategory = "Home furnishing",
                ProductTransport = "Full Load",
                IsProductPerishable = false,
                Notes = "Heavy standard item"
            });
            context.Products.AddOrUpdate(new Product.Domain.Models.Product
            {

                ProductId = Guid.NewGuid(),
                ProductName = "Electronics Product",
                ProductCategory = "Fridge",
                ProductTransport = "Full Load",
                IsProductPerishable = false,
                Notes = "Fragile item"
            });
           
            context.SaveChanges();
        }
    }
}
