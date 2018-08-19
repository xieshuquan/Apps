using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apps.WebApp.Repository.DbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Apps.WebApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; private set; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
            });
            services.AddDbContextPool<ProfileDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("Profile"));
            });
            services.AddDbContextPool<ReportDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("Report"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}"
                );
            });
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var dbContexts = scope.ServiceProvider.GetServices<DbContext>();
                foreach (var dbContext in dbContexts)
                {
                    dbContext.Database.EnsureCreated();
                }
            }
        }
    }
}
