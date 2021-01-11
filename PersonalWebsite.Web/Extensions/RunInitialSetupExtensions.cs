using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalWebsite.Web.EntityFramework.Entities;

namespace PersonalWebsite.Web.Extensions
{
    public static class RunInitialSetupExtensions
    {
        public static void RunInitialSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("InitialSetup:RunInitialSetup"))
            {
                var serviceProvider = services.BuildServiceProvider();
                var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
                userManager.CreateAsync(new ApplicationUser { UserName = configuration["InitialSetup:DefaultUser:Username"] }, configuration["InitialSetup:DefaultUser:Password"]).GetAwaiter().GetResult();
            }
        }
    }
}
