using System.Threading.Tasks;

namespace PersonalWebsite.Web.Api.Posts.SetPostContent
{
    public interface ISetPostContentService
    {
        Task SetPostContentAsync(SetPostContentRequest request);
    }
}
