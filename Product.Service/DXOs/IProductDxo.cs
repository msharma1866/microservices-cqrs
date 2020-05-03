using Product.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service.DXOs
{
    public interface IProductDxo
    {
        ProductDto MapProductDto(Product.Domain.Models.Product product);
    }
}
