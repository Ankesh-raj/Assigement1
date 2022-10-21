using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProductBLL.Services;
using ProductDAL;
using ProductDAL.Repost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI
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
            string connectionstr = Configuration.GetConnectionString("sqlConnection");
            services.AddDbContext<ProductDbContext>(Options => Options.UseSqlServer(connectionstr));

            services.AddTransient<ArticleService, ArticleService>();
            services.AddTransient<IArticleRepo, ArticleRepo>();

            services.AddTransient<ColorService, ColorService>();
            services.AddTransient<IColorRepo, ColorRepo>();

            services.AddTransient<ProductService, ProductService>();//adding services
            services.AddTransient<IProductRepo, ProductRepo>();

            services.AddTransient<SizeScaleService, SizeScaleService>();
            services.AddTransient<ISizeScaleRepo, SizeScaleRepo>();

            services.AddControllers();

            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ProductAPI",
                    Description = "Product Management API System"
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

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API"));

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
