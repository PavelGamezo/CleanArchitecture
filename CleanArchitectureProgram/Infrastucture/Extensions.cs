using CleanArchitecture.Infrastucture.EF;
using CleanArchitecture.Infrastucture.EF.Options;
using CleanArchitecture.Shared.Options;
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
            return services;
        }
    }
}
