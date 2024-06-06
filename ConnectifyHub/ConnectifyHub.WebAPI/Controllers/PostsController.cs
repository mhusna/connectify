using ConnectifyHub.Application.Features.Queries.PostQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectifyHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IMediator _mediator;

        public PostsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> GetAll(PostGetAll model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
    }
}
