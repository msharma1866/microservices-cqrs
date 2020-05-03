using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

using Product.Data.Repository;
using Product.Domain.Events;

namespace Product.Service.Subscribers
{
    public class CreatedProductCommandHandler : INotificationHandler<ProductCreatedEvent>
    {
        private readonly IProductRepository _productRespository;
        //private readonly ILogger _logger;
        public CreatedProductCommandHandler(IProductRepository prodRepo)//, ILogger logger)
        {
            _productRespository = prodRepo;
            //_logger = logger;
        }
        public async Task Handle(ProductCreatedEvent notification, CancellationToken cancellationToken)
        {
            var product = await _productRespository.GetAsync(n => n.ProductId == notification.ProductId);

            if (product == null)
            {
                //TODO: Handle next business logic if customer is not found
               // _logger.LogWarning("Product is not found by product id from publisher");
            }
            else
            {
               // _logger.LogInformation($"Product has found by product id: {notification.ProductId} from publisher");
            }
        }
    }
}
