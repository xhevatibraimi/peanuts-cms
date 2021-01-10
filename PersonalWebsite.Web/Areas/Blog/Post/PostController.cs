using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Web.Areas.Blog.Post
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("/blog/{slug}")]
        public async Task<IActionResult> GetPostPage(string slug)
        {
            var post = await _postService.GetPostBySlugAsync(slug);
            if (post != null)
            {
                return View(Views.Blog.Post.PostView, post);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet("/api/blog/{slug}")]
        public async Task<IActionResult> GetPostBySlug(string slug)
        {
            var post = await _postService.GetPostBySlugAsync(slug);
            if (post != null)
            {
                return Ok(post);
            }

            return NotFound();
        }
    }
}
