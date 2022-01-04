using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: HostingStartup(typeof(UfoBlog.Domain.DomainStartup))]
namespace UfoBlog.Domain
{

    public class DomainStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services => {
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
            });
        }
    }
}
