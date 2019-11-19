using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP.Api
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureServices(IServiceCollection services,IConfiguration configuration)
        {
            services.AddMyApplicationDataContext(configuration);
            return services;
        }
    }
}
