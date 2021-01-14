using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalWebsite.Web.Api.Posts.GetAll;
using PersonalWebsite.Web.Api.Posts.SetPostContent;
using PersonalWebsite.Web.Areas.Blog.Post;
using PersonalWebsite.Web.Areas.Membership.Login;
using PersonalWebsite.Web.EntityFramework;
using PersonalWebsite.Web.EntityFramework.Entities;
using PersonalWebsite.Web.Extensions;

namespace PersonalWebsite.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", reloadOnChange: true, optional: false)
                .AddJsonFile("appsettings.ignore.json", reloadOnChange: true, optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<PeanutsCmsDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<PeanutsCmsDbContext>();
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/membership/login";
            });
            services.RunInitialSetup(Configuration);
            AddServices(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void AddServices(IServiceCollection services)
        {
            services.AddTransient<ILoginService, LoginService>();

            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IGetAllPostsService, GetAllPostsService>();
            services.AddTransient<ISetPostContentService, SetPostContentService>();
        }
    }
}
