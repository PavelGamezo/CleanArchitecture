﻿using CleanArchitecture.Infrastucture.EF.Contexts;
using CleanArchitecture.Infrastucture.EF.Options;
using CleanArchitecture.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastucture.EF
{
    internal static class Extensions
    {
        public static IServiceCollection AddSql(this IServiceCollection services, IConfiguration configuration)
        {
            var sqlPptions = configuration.GetOptions<SqlOptions>("Sql");

            services.AddDbContext<ReadDbContext>(options =>
            {
                options.UseSqlServer(sqlPptions.ConnectionString);
            });
            services.AddDbContext<WriteDbContext>(options =>
            {
                options.UseSqlServer(sqlPptions.ConnectionString);
            });

            return services;
        }
    }
}