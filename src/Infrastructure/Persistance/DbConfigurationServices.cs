using Domain.Entities.Identity;
using Infrastructure.Persistance.Contexts;
using Infrastructure.Persistance.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance
{
    public static class DbConfigurationServices
    {
        public static void AddDbServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ProjECommerceDbContext>(options => options.UseSqlServer(configuration["SQLSERVER:ConnectionStrings"]));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ProjECommerceDbContext>().AddDefaultTokenProviders();

            services.AddTransient<DataSeeding>();
        }
    }
}
