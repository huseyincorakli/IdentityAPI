using IdentityAPI.Application.DTOs.Token;

namespace IdentityAPI.Application.Features.Commands.AppUser.Login.UserLogin
{
    public class UserLoginCommandResponse
    {
        public Token Token { get; set; }
    }
}
