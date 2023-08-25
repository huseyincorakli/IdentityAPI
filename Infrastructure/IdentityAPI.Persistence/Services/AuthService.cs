using IdentityAPI.Application.Abstraction.Services;
using IdentityAPI.Application.Abstraction.Token;
using IdentityAPI.Application.DTOs.Token;
using IdentityAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace IdentityAPI.Persistence.Services
{
    public class AuthService : IAuthService
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;
        readonly ITokenHandler _tokenHandler;

        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenHandler tokenHandler)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
        }

        public async Task<Token> LoginAsync(string usernameOrEmail, string password, int accessTokenLife)
        {
            AppUser user = await _userManager.FindByNameAsync(usernameOrEmail);
            if (user==null)
            {
                user =await _userManager.FindByEmailAsync(usernameOrEmail);
            }
            if (user==null)
            {
                throw new Exception("Böyle bir hesap yok!");
            }
            SignInResult result= await _signInManager.CheckPasswordSignInAsync(user, password, false);
            if (result.Succeeded)
            {
                Token token = _tokenHandler.CreateAccessToken(5);
                return token;
            }
            else
                throw new Exception("Yanlış kullanıcı bilgileri!");
        }
    }
}
