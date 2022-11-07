using Gust.Core.Areas.Identity.Data;
using Gust.Core.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

[assembly: HostingStartup(typeof(Gust.Core.Areas.Identity.IdentityHostingStartup))]
namespace Gust.Core.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GustCoreContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Gust")));

                services.AddDefaultIdentity<GustCoreUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<GustCoreContext>();

            });
        }
    }
}
