using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using CoreWebApi.DataAccess.Entities;
using CoreWebApi.Business.Orchestrators;
using CoreWebApi.Business.Interfaces;

namespace CoreWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IConfigurationRoot>(c => Configuration);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            ConfigureDependencyInjection(services, Configuration);
        }

        private static void ConfigureDependencyInjection(IServiceCollection services, IConfiguration configurationRoot)
        {
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<SignalRDemoContext>(
                    options => options.UseSqlServer(configurationRoot.GetConnectionString("SignalRDemo")), ServiceLifetime.Transient);

            services.AddTransient<IProductOrchestrator, ProductOrchestrator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
    
}
