using T = IdentityAPI.Application.DTOs.Token;
namespace IdentityAPI.Application.Abstraction.Token
{
    public interface ITokenHandler
    {
        T.Token CreateAccessToken(int second);
    }
}
