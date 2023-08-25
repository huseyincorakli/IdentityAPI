using IdentityAPI.Application.Abstraction.Services;
using MediatR;

namespace IdentityAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;

        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
          var response = await _userService.CreateAsync(new()
            {
                UserName = request.UserName,
                Email = request.Email,
                Password = request.Password,
                PasswordConfirm = request.PasswordConfirm
            });
            return new CreateUserCommandResponse
            {
                Message = response.Message,
                Succeeded = response.Succeeded
            };
        }
    }
}
