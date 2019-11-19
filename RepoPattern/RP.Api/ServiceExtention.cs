using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RP.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP.Api
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddMyApplicationDataContext(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<SampleDataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(nameof(SampleDataContext))));
            return services;
        }
    }
}
