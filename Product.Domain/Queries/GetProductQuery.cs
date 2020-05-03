using MediatR;
using Newtonsoft.Json;
using Product.Domain.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Queries
{
    public class GetProductQuery : IRequest<ProductDto> //QueryBase<ProductDto>
    {
        [JsonConstructor]
        public GetProductQuery(Guid id)
        {
            ProductId = id;
        }

        [JsonProperty("id")]
        [Required]
        public Guid ProductId { get; set; }
    }
}
