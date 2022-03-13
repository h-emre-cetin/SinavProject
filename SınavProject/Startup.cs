using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SınavProject
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
            services.AddControllersWithViews();
            services.AddMvc();

            services.AddScoped<ISikService, SikManager>();
            services.AddScoped<ISikDal, EfSikDal>();

            services.AddScoped<ISinavService, SinavManager>();
            services.AddScoped<ISinavDal, EfSinavDal>();

            services.AddScoped<ISinavKategoriService, SinavKategoriManager>();
            services.AddScoped<ISinavKategoriDal, EfSinavKategoriDal>();


            services.AddScoped<ISoruService, SoruManager>();
            services.AddScoped<ISoruDal, EfSoruDal>();


            services.AddScoped<ISoruKategoriService, SoruKategoriManager>();
            services.AddScoped<ISoruKategoriDal, EfSoruKategoriDal>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
