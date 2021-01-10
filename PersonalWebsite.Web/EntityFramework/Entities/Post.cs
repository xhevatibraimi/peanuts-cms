using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Web.EntityFramework.Entities
{
    public class Post
    {
        [Key]
        public string Id { get; set; }
        public DateTime PublishingDate { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
