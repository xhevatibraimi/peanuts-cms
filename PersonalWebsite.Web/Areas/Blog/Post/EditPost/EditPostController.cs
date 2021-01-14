using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Web.Areas.Blog.Post.EditPost
{
    public class EditPostController : Controller
    {
        [Authorize]
        [HttpGet("/blog/posts/{id}/edit")]
        public IActionResult EditPost(string id)
        {
            return View(Views.Blog.Post.EditPostView, new EditPostViewModel { Id = id });
        }
    }
}
