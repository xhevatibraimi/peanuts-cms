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

        [HttpGet("/api/blog/{id}")]
        public async Task<IActionResult> GetPostById(string id)
        {
            var post = await _postService.GetPostByIdAsync(id);
            if (post != null)
            {
                return Ok(post);
            }

            return NotFound();
        }
    }
}
