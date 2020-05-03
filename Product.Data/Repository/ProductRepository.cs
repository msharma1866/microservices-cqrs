using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data.Repository
{
    public class ProductRepository: Repository<Product.Domain.Models.Product>, IProductRepository
    {
        public ProductRepository(ProductDbContext productDbContext) : base(productDbContext)
        {

        }
    }
}
