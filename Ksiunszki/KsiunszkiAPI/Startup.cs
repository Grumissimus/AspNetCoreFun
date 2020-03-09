using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using KsiunszkiAPI.Options;
using KsiunszkiAPI.Contracts;
using KsiunszkiAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace KsiunszkiAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ApiDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSwaggerGen( x => x.SwaggerDoc(
                ApiRoutes.Version, 
                new Microsoft.OpenApi.Models.OpenApiInfo{Title = "Ksiunszki Resource API", Version = ApiRoutes.Version}
            ) );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            SwaggerOptions swaggerOption = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOption);
            app.UseSwagger(option => option.RouteTemplate = swaggerOption.JsonRoute);
            app.UseSwaggerUI(option => option.SwaggerEndpoint(swaggerOption.UIEndpoint, swaggerOption.Description) );

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
