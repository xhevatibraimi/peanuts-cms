using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Web.Areas.Membership.Login
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet("/membership/login")]
        public IActionResult Login(string returnUrl = "/")
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(Views.Membership.Login.LoginView);
        }

        [ValidateAntiForgeryToken]
        [HttpPost("/membership/login")]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = "/")
        {
            var succeeded = await _loginService.LoginAsync(model);
            if (succeeded)
            {
                return Redirect(returnUrl);
            }

            return View(Views.Membership.Login.LoginView);
        }
    }
}
