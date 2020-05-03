using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Product.Domain.Dto;

namespace Product.Service.DXOs
{
    public class ProductDxo : IProductDxo
    {
        private readonly IMapper mapper = null;
        public ProductDxo()
        {
            var config = new MapperConfiguration(confg =>
            {
                confg.CreateMap<Product.Domain.Models.Product, Product.Domain.Dto.ProductDto>()
                .ForMember(org => org.ProductIdentifier, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(org => org.ProductName, opt => opt.MapFrom(src => src.ProductName))
                .ForMember(org => org.ProductCatName, opt => opt.MapFrom(src => src.ProductCategory))
                .ForMember(org => org.ProductTransport, opt => opt.MapFrom(src => src.ProductTransport))
                .ForMember(org => org.IsProductPerishable, opt => opt.MapFrom(src => src.IsProductPerishable));
            });
            mapper = config.CreateMapper();
        }

        public ProductDto MapProductDto(Product.Domain.Models.Product product)
        {
            return mapper.Map<ProductDto>(product);
        }
    }
}
