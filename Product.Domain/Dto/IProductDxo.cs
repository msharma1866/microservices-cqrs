using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Dto
{
    interface IProductDxo
    {
        ProductDto MapProductDto(Product.Domain.Models.Product product);
    }
}
