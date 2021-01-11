using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Web.EntityFramework;

namespace PersonalWebsite.Web.Api.Posts.GetAll
{
    public class GetAllPostsService : IGetAllPostsService
    {
        private readonly PeanutsCmsDbContext _context;

        public GetAllPostsService(PeanutsCmsDbContext context)
        {
            _context = context;
        }

        public async Task<GetAllPostsResponse> GetAllPostsAsync()
        {
            var result = await _context.Posts.Select(x => new GetAllPostsResponse.PostViewModel
            {
                Id = x.Id,
                PublishDate = x.PublishingDate,
                Content = x.Content,
                Title = x.Title,
                Slug = x.Slug
            }).ToListAsync();

            return new GetAllPostsResponse
            {
                Posts = result
            };
        }
    }
}
