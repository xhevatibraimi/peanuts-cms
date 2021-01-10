using System.Threading.Tasks;

namespace PersonalWebsite.Web.Api.Posts.GetAll
{
    public interface IGetAllPostsService
    {
        Task<GetAllPostsResponse> GetAllPostsAsync();
    }
}
