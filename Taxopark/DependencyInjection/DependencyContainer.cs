using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Taxopark.Infrastructure.Data;

namespace DependencyInjection
{
    public static class DependencyContainer
    {
        public static void AddDependencies(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureMySQLContext(services, configuration);
        }

        private static void ConfigureMySQLContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["mysqlconnection:connectionString"];
            services.AddDbContext<TaxoparkContext>(opt => opt.UseMySql(connectionString));
        }
    }
}
