using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Web.EntityFramework.Entities;

namespace PersonalWebsite.Web.EntityFramework
{
    public class PersonalWebsiteDbContext : DbContext
    {
        public PersonalWebsiteDbContext(DbContextOptions<PersonalWebsiteDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Post> Posts { get; set; }
    }
}
