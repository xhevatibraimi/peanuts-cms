using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Web.Api.Posts.GetAll
{
    public class GetAllPostsController : ControllerBase
    {
        private readonly IGetAllPostsService _getAllPostService;

        public GetAllPostsController(IGetAllPostsService getAllPostService)
        {
            _getAllPostService = getAllPostService;
        }

        [HttpGet("/api/posts")]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _getAllPostService.GetAllPostsAsync();
            return Ok(posts);
        }
    }
}
