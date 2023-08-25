using MediatR;

namespace IdentityAPI.Application.Features.Commands.AppUser.Login.UserLogin
{
    public class UserLoginCommandRequest:IRequest<UserLoginCommandResponse>
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
