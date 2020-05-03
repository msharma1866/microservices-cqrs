using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Events
{
    public class ProductCreatedEvent : INotification
    {
        public Guid ProductId { get; }

        public ProductCreatedEvent(Guid id)
        {
            ProductId = id;
        }
    }
}
