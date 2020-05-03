using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace Product.Domain.Queries
{
    public class SampleQuery : IRequest<Product.Domain.Dto.ProductDto>
    {
        public SampleQuery(int id)
        {
            Identifier = id;
        }

        public int Identifier { get; set; }
    }
}
