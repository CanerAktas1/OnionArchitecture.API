using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionApi.Application.Features.Products.Queries.GetAllProducts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OnionApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
          var response =  await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }
    }
}
