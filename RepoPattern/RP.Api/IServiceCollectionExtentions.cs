using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RP.Data.DataContext;
using RP.Data.Repositories;
using RP.Domain.Core.Entities;
using RP.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP.Api
{
    public static class IServiceCollectionExtentions
    {
        public static IServiceCollection AddMyApplicationDataContext(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<SampleDataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(nameof(SampleDataContext))));
            services.AddScoped<ISampleDataContext>(provider => provider.GetService<SampleDataContext>());
            return services;
        }

        public static IServiceCollection AddMyApplicationServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(ISampleDataContext),typeof(SampleDataContext));
            services.AddTransient(typeof(IAsyncRepository<>),typeof(Repository<>));
            services.AddTransient(typeof(IRepository<>),typeof(Repository<>));

            return services;
        }
    }
}
