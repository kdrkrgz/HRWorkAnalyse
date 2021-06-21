using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace HRWorkAnalyse.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServicesBaseConfiguration(this IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            return services;
        }

        public static IServiceCollection AddCorsConfiguration(this IServiceCollection services)
        {
            services.AddCors(builder =>
            {
                builder.AddPolicy("DefaultCors", opt => opt.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());
            });
            return services;
        }
    }
}
