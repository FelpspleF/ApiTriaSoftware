using ApiTriaSoftware.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTriaSoftware.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<ApiTriaSoftwareContext>(option => option.UseNpgsql(configuration.GetConnectionString("DefaultConnectionString")));
            //services.AddScoped<IUser, User>();

            return services;
        }
    }
}
