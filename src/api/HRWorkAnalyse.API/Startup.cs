using HRWorkAnalyse.Data.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRWorkAnalyse.API.Extensions;
using HRWorkAnalyse.Business.Mappings.AutoMapper;
using Microsoft.OpenApi.Models;

namespace HRWorkAnalyse.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServicesBaseConfiguration();
            services.AddDbContext<HrWorkAnalyseDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HrAnalyseDbContext")));
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddCorsConfiguration();
            services.AddSwaggerGen(s => {
                s.SwaggerDoc("HrWorkAnlayseAPI", new OpenApiInfo {
                    Version = "1.0.0",
                    Title = ".Net Core Web Api With Swagger",
                    Description = ".Net Core Web Api With Swagger",
                    Contact = new OpenApiContact(){
                        Name = "Book Store API Support",
                        Email = "kadir@kadirkaragoz.com",
                        Url = new Uri("https://kadirkaragoz.com")
                    },
                    TermsOfService = new Uri("http://example.com/terms/")
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("DefaultCors");

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/HrWorkAnlayseAPI/swagger.json", "HRWorkAnlyse.API v1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
