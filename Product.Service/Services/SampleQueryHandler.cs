using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Product.Domain.Dto;
using Product.Domain.Queries;

namespace Product.Service.Services
{
    public class SampleQueryHandler : IRequestHandler<SampleQuery, ProductDto>
    {
        public async Task<ProductDto> Handle(SampleQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new ProductDto());
            //if (request.Identifier != 0)
            //    return await Task.FromResult(true);
            //return await Task.FromResult(false);
        }
    }
}
