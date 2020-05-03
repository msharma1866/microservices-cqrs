using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ValuesController : ApiControllerBase
    {
        public ValuesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        public ActionResult<string> Get()
        {
            return "hello";
        }
    }
}