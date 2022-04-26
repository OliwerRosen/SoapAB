using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoapAB.Areas.Identity.Data;
using SoapAB.Data;

[assembly: HostingStartup(typeof(SoapAB.Areas.Identity.IdentityHostingStartup))]
namespace SoapAB.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SoapDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SoapAB_DBContextConnection")));

                services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SoapDBContext>();
            });
        }
    }
}