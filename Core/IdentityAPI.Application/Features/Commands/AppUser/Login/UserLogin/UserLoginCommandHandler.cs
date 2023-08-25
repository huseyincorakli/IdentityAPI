using IdentityAPI.Application.Abstraction.Services;
using IdentityAPI.Application.DTOs.Token;
using MediatR;

namespace IdentityAPI.Application.Features.Commands.AppUser.Login.UserLogin
{
    public class UserLoginCommandHandler : IRequestHandler<UserLoginCommandRequest, UserLoginCommandResponse>
    {
        readonly IAuthService  _authService;

        public UserLoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<UserLoginCommandResponse> Handle(UserLoginCommandRequest request, CancellationToken cancellationToken)
        {
            Token token = await _authService.LoginAsync(request.UserNameOrEmail, request.Password, 15);

            return new()
            {
                Token = token
            };
        }
    }
}
