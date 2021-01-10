using System;
using System.Collections.Generic;

namespace PersonalWebsite.Web.Api.Posts.GetAll
{
    public class GetAllPostsResponse
    {
        public List<PostViewModel> Posts { get; set; }

        public class PostViewModel
        {
            public string Id { get; set; }
            public string Slug { get; set; }
            public string Title { get; set; }
            public DateTime PublishDate { get; set; }
            public string Content { get; set; }
        }
    }
}
