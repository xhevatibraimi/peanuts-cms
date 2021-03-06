﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Web.EntityFramework;

namespace PersonalWebsite.Web.Areas.Blog.Post
{
    public class PostService : IPostService
    {
        private readonly PeanutsCmsDbContext _context;

        public PostService(PeanutsCmsDbContext context)
        {
            _context = context;
        }

        public async Task<PostViewModel> GetPostByIdAsync(string id)
        {
            var dbPost = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);
            if (dbPost == null)
            {
                return null;
            }

            return new PostViewModel
            {
                Id = dbPost.Id,
                PublishDate = dbPost.PublishingDate,
                Content = dbPost.Content,
                Title = dbPost.Title,
                Slug = dbPost.Slug
            };
        }

        public async Task<PostViewModel> GetPostBySlugAsync(string slug)
        {
            var dbPost = await _context.Posts.FirstOrDefaultAsync(x => x.Slug == slug);
            if (dbPost == null)
            {
                return null;
            }

            return new PostViewModel
            {
                Id = dbPost.Id,
                PublishDate = dbPost.PublishingDate,
                Content = dbPost.Content,
                Title = dbPost.Title,
                Slug = dbPost.Slug
            };
        }
    }
}
