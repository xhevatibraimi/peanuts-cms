using System.Threading.Tasks;

namespace PersonalWebsite.Web.Areas.Blog.Post
{
    public interface IPostService
    {
        Task<PostViewModel> GetPostByIdAsync(string postId);
        Task<PostViewModel> GetPostBySlugAsync(string slug);
    }
}
