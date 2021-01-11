using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Web.Areas.Blog.Post.EditPost
{
    public class EditPostController : Controller
    {
        [Authorize]
        [HttpGet("/blog/posts/edit/{slug}")]
        public IActionResult EditPost(string slug)
        {
            return View(Views.Blog.Post.EditPostView, new EditPostViewModel { Slug = slug });
        }
    }
}
