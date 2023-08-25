using IdentityAPI.Application.Abstraction.Services;
using IdentityAPI.Application.DTOs.User;
using IdentityAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace IdentityAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUser user)
        {
            if (user.Password!=user.PasswordConfirm)
            {
                return new() { Message="Şifreler aynı olmalı", Succeeded= false};
            }
            IdentityResult result  = await _userManager.CreateAsync(new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName= user.UserName,
                Email= user.Email,

            },user.Password) ;
            CreateUserResponse response= new CreateUserResponse
            {
                Succeeded= result.Succeeded,
            };
            if (result.Succeeded)
            {
                response.Message = "Kayıt Başarılı";   
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code}-{error.Description}";
                }
            }
            return response;
        }
    }
}
