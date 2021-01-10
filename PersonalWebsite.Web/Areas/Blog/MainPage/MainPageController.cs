using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Web.Areas.Blog.MainPage
{
    public class MainPageController : Controller
    {
        [HttpGet("/blog")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
