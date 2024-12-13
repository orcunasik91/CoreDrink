using CoreDrink.WebUI.Data;
using CoreDrink.WebUI.Data.Interfaces;
using CoreDrink.WebUI.Data.Models;
using CoreDrink.WebUI.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoreDrink.WebUI
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IWebHostEnvironment webHostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(webHostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.Development.json")
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddMvc(opt =>
            {
                opt.EnableEndpointRouting = false;
            });
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IDrinkRepository, DrinkRepository>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            DbInitializer.Seed(serviceProvider);
        }
    }
}