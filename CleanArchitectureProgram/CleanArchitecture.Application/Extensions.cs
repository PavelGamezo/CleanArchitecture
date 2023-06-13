using CleanArchitecture.Domain.Factories;
using CleanArchitecture.Domain.Policies;
using CleanArchitecture.Shared;
using CleanArchitecture.Shared.Command;
using CleanArchitecture.Shared.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddCommands();
            services.AddSingleton<IPackingListFactory, PackingListFactory>();

            services.Scan(q => q.FromAssemblies(typeof(IPackingItemPolicy).Assembly)
                .AddClasses(w => w.AssignableTo<IPackingItemPolicy>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            return services;
        }
    }
}
