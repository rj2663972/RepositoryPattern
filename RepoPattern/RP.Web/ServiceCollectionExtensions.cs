using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using RP.Domain.Core.Interfaces;


namespace RP.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyApplicationServices(this IServiceCollection services)
        {
            //services.Scan(scan => scan
            //        .FromApplicationDependencies()
            //        .AddClasses(classes => classes.AssignableTo<ITransientService>())
            //            .AsImplementedInterfaces()
            //            .WithTransientLifetime()
            //         .AddClasses(classes => classes.AssignableTo(typeof(IRepository<>)))
            //            .AsImplementedInterfaces()
            //            .WithTransientLifetime()
            //         .AddClasses(classes => classes.AssignableTo(typeof(IAsyncRepository<>)))
            //            .AsImplementedInterfaces()
            //            .WithTransientLifetime()
            //        .AddClasses(classes => classes.AssignableTo<IScopedService>())
            //            .As<IScopedService>()
            //            .WithScopedLifetime());



            return services;
        }

        public static void RegisterAllTypes<T>(this IServiceCollection services, Assembly[] assemblies,
        ServiceLifetime lifetime = ServiceLifetime.Transient)
        {
            var typesFromAssemblies = assemblies.SelectMany(a => a.DefinedTypes.Where(x => x.GetInterfaces().Contains(typeof(T))));
            foreach (var type in typesFromAssemblies)
                services.Add(new ServiceDescriptor(typeof(T), type, lifetime));
        }
    }
}
