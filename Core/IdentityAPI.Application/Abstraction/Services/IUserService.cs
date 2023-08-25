using IdentityAPI.Application.DTOs.User;

namespace IdentityAPI.Application.Abstraction.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser user);
    }
}
