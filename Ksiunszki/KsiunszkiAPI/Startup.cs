using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using KsiunszkiAPI.Options;
using Microsoft.EntityFrameworkCore;
using KsiunszkiAPI.Entities;
using KsiunszkiAPI.Services;
using API.Services;

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
            services.AddDbContext<KsiunszkiContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();

            services.AddScoped<IAuthorService,AuthorService>();
            services.AddScoped<IBookService, BookService>();

            services.AddSwaggerGen(x => x.SwaggerDoc(
               "v1",
               new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Ksiunszki Resource API", Version = "v1" }
           ));


            services.AddMvc().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd";
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });
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
