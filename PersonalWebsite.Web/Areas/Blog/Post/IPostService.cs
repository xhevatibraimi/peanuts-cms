using System.Threading.Tasks;

namespace PersonalWebsite.Web.Areas.Blog.Post
{
    public interface IPostService
    {
        Task<PostViewModel> GetPostByTitleAsync(string postTitle);
        Task<PostViewModel> GetPostBySlugAsync(string postId);
    }
}
