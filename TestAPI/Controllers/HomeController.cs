using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using System.Threading.Tasks;
using TestAPI.CQRS.Commands.Products.Requests;
using TestAPI.CQRS.Queries.Products.Requests;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] GetAllProductsQueryRequest getAllProductsQueryRequest)
        {
            var result= await _mediator.Send(getAllProductsQueryRequest);

            return Ok(result);
        }

        [HttpPost("createproduct")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommandRequest createProductCommandRequest)
        {
            var result = await _mediator.Send(createProductCommandRequest);

            return Ok(result);
        }
    }
}
