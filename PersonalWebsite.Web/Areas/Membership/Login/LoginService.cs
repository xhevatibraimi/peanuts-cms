using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PersonalWebsite.Web.EntityFramework.Entities;

namespace PersonalWebsite.Web.Areas.Membership.Login
{
    public class LoginService : ILoginService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public LoginService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> LoginAsync(LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByNameAsync(loginViewModel.Username);
            if (user == null)
            {
                return false;
            }

            var sigInResult = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, isPersistent: true, lockoutOnFailure: false);
            return sigInResult.Succeeded;
        }
    }
}
