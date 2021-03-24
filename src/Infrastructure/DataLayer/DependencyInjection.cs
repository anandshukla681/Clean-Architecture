using ApplicationApi.Interface;
using DataLayer.StaticResources;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IDefectRepository, DefectRepository>();

            return services;
        }
    }
}
