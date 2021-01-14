using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Web.EntityFramework;

namespace PersonalWebsite.Web.Api.Posts.SetPostContent
{
    public class SetPostContentService : ISetPostContentService
    {
        private readonly PeanutsCmsDbContext _context;

        public SetPostContentService(PeanutsCmsDbContext context)
        {
            _context = context;
        }

        public async Task SetPostContentAsync(SetPostContentRequest request)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (post == null)
            {
                throw new Exception("post does not exist");
            }

            post.Content = request.Content ?? string.Empty;

            await _context.SaveChangesAsync();
        }
    }
}
