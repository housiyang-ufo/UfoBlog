using Refit;
using System;
using System.Reflection;
using UfoBlog.Domain.Model;
using UfoBlog.Domain.Interface;
using UfoBlog.Domain.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


[assembly: HostingStartup(typeof(UfoBlog.Domain.DomainStartup))]
namespace UfoBlog.Domain
{
    public class DomainStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
                services.AddDbContextFactory<BlogContext>(opt => opt.UseSqlite(SettingExtensions.connectionStrings));  //Configuration.GetConnectionString("Default")

                //Refit服务注册
                //services
                //    .AddRefitClient<IAccountClient>().ConfigureHttpClient(options =>
                //    {
                //        options.BaseAddress = new Uri(Configuration.GetValue(typeof(String), "URLS").ToString());
                //    });
            });
        }
    }
}
