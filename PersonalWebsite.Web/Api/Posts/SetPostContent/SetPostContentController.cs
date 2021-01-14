using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Web.Api.Posts.SetPostContent
{
    public class SetPostContentController : ControllerBase
    {
        private readonly ISetPostContentService _setPostContentService;

        public SetPostContentController(ISetPostContentService setPostContentService)
        {
            _setPostContentService = setPostContentService;
        }

        [Authorize]
        [HttpPost("/api/blog/posts/{id}/set-post-content")]
        public async Task<IActionResult> SetPostContent([FromRoute] string id, [FromForm] SetPostContentRequest request)
        {
            await _setPostContentService.SetPostContentAsync(request);
            return Ok();
        }
    }
}
