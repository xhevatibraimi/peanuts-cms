using System.Threading.Tasks;

namespace PersonalWebsite.Web.Areas.Membership.Login
{
    public interface ILoginService
    {
        Task<bool> LoginAsync(LoginViewModel loginViewModel);
    }
}
