using CoreDrink.WebUI.Data.Interfaces;
using CoreDrink.WebUI.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CoreDrink.WebUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(opt =>
            {
                opt.EnableEndpointRouting = false;
            });
            services.AddTransient<ICategoryRepository, MockCategoryRepository>();
            services.AddTransient<IDrinkRepository, MockDrinkRepository>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}