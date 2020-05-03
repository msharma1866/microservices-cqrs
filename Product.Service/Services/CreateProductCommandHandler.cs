using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

using Product.Data.Repository;
using Product.Domain.Commands;
using Product.Domain.Dto;
using Product.Domain.Events;
using Product.Service.DXOs;

namespace Product.Service.Services
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;       
        private readonly IProductDxo _productDxo;
        public CreateProductCommandHandler(IProductRepository productRepository, IMediator mediator,  IProductDxo productDxo)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));            
            _productDxo = productDxo ?? throw new ArgumentNullException(nameof(productDxo));
        }
        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product.Domain.Models.Product(request.ProductName, request.ProductCategory, request.ProductTransport, request.IsProductPerishable, request.Notes);
            _productRepository.Add(product);
            
            if(await _productRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException();
            }
            await _mediator.Publish(new ProductCreatedEvent(product.ProductId), cancellationToken);
            var productDto = _productDxo.MapProductDto(product);
            return productDto;
            
        }
    }
}
