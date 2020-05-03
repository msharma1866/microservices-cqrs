using MediatR;
//using Microsoft.Extensions.Logging;
using Product.Data.Repository;
using Product.Domain.Dto;
using Product.Domain.Queries;
using Product.Service.DXOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Service.Services
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductDxo _productDxo;
        //private readonly ILogger _logger;

        public GetProductQueryHandler(IProductRepository productRepository, IProductDxo productDxo)//, ILogger<GetProductQueryHandler> logger)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _productDxo = productDxo ?? throw new ArgumentNullException(nameof(productDxo));
            //_logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<ProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetAsync(p =>
             p.ProductId == request.ProductId);
            if(product != null)
            {
               //_logger.Log(LogLevel.Information, $"Product of prod id {request.ProductId} successfully fetched");
                var productDto = _productDxo.MapProductDto(product);
                return productDto;
            }
            return null;
        }
    }
}
