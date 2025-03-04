using MediatR;
using MediatRandCQRS_Example.Mediatr.Commands;
using MediatRandCQRS_Example.Mediatr.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRandCQRS_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }
        
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetProductByIdQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpPost()]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
