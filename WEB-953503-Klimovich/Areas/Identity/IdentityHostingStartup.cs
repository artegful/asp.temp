using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WEB_953503_Klimovich.Data;
using WEB_953503_Klimovich.Entities;

[assembly: HostingStartup(typeof(WEB_953503_Klimovich.Areas.Identity.IdentityHostingStartup))]
namespace WEB_953503_Klimovich.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
        }
    }
}