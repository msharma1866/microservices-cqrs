using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Product.Domain.Dto;
using Product.Domain.Queries;

namespace Customer.API.Controllers
{

    public class ProductController : ApiControllerBase

    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id">Id of prduct</param>
        /// <returns>product information</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<string>> GetProductAsync(Guid id)
        {
            var result = Single(await QueryAsync(new GetProductQuery(id)));
            return JsonConvert.SerializeObject(result,Formatting.Indented);
        }

        [HttpGet]
       // [ProducesResponseType(typeof(ProductDto), 200)]
        public ActionResult<string> Get()
        {
            var p =  JsonConvert.SerializeObject(new Product.Domain.Models.Product { ProductName = "Test12" },Formatting.Indented) ;
            return p;
        }
       
    }
}