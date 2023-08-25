using T = IdentityAPI.Application.DTOs.Token;
namespace IdentityAPI.Application.Abstraction.Services.Authentication
{
    public interface IInternalAuthentication
    {
        Task<T.Token> LoginAsync(string usernameOrEmail, string password,int accessTokenLife);
    }
}
