using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalWebsite.Web.EntityFramework;

namespace PersonalWebsite.Web.Areas.Home
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PersonalWebsiteDbContext _context;

        public HomeController(ILogger<HomeController> logger, PersonalWebsiteDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(Views.Home.HomeView, _context.Posts.ToList());
        }
    }
}
