using Microsoft.AspNetCore.Hosting;
using System;

[assembly: HostingStartup(typeof(UfoBlog.Application.ApplicaionStartup))]
namespace UfoBlog.Application
{
    public class ApplicaionStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {

        }
    }
}
