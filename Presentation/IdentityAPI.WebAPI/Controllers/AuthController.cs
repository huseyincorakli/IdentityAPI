using IdentityAPI.Application.Features.Commands.AppUser.Login.UserLogin;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Login(UserLoginCommandRequest userLoginCommandRequest)
        {
           UserLoginCommandResponse response =  await _mediator.Send(userLoginCommandRequest);
            return Ok(response);
        }
    }
}
