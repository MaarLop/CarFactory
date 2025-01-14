﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Modules.CarFactory.Core.Domain;

namespace Modules.CarFactory.Core.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddCoreModule(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining(typeof(Sale));
            });

            return services;
        }
    }
}