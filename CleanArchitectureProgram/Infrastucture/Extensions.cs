using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastucture.EF;
using CleanArchitecture.Infrastucture.EF.Options;
using CleanArchitecture.Infrastucture.Services;
using CleanArchitecture.Shared.Options;
using CleanArchitecture.Shared.Queries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastucture
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddSql(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherService, DumbWeatherService>();

            return services;
        }
    }
}
