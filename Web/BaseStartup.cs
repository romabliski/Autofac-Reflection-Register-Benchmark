using System;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web
{
    public abstract class BaseStartup
    {
        public BaseStartup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
        }

        public IContainer ApplicationContainer { get; protected set; }

        public IConfigurationRoot Configuration { get; protected set; }

        public void Configure(
          IApplicationBuilder app,
          IApplicationLifetime appLifetime)
        {
            app.UseMvc();
        }

        protected virtual void RegisterServices(ContainerBuilder container)
        {
        }

        public abstract IServiceProvider ConfigureServices(IServiceCollection services);
    }
}