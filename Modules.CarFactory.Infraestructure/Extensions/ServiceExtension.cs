﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Modules.CarFactory.Core.Abstractions;

namespace Modules.CarFactory.Infraestructure.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {
            services.AddDbContext<SaleDbContext>(options =>
            {
                options.UseInMemoryDatabase("Sales");
            });

            services.AddScoped<ISaleRepository, SaleRepository>();

            return services;
        }
    }
}