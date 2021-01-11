using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Web.EntityFramework.Entities;

namespace PersonalWebsite.Web.EntityFramework
{
    public class PeanutsCmsDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public PeanutsCmsDbContext(DbContextOptions<PeanutsCmsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
