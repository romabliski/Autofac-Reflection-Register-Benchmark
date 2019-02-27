using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Autofac_Test
{
    public class StartupReflection
    {
        public StartupReflection(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
        }


        public IContainer ApplicationContainer { get; private set; }

        public IConfigurationRoot Configuration { get; private set; }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Add services to the collection.
            services.AddMvc();

            // Create the container builder.
            var builder = new ContainerBuilder();

            var allDomainTypes = AppDomain.CurrentDomain.Load("Autofac_Test").GetTypes();
            for (int i = 0; i < allDomainTypes.Length; i++)
            {
                var typeInterface = allDomainTypes[i].GetInterface(string.Concat('I', allDomainTypes[i].Name));
                if (typeInterface != null)
                {
                    builder.RegisterType(allDomainTypes[i]).As(typeInterface).InstancePerDependency();
                }
            }

            builder.Populate(services);
            this.RegisterServices(builder);
            this.ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(this.ApplicationContainer);
        }

        protected virtual void RegisterServices(ContainerBuilder container)
        {
        }


        // Configure is where you add middleware. This is called after
        // ConfigureServices. You can use IApplicationBuilder.ApplicationServices
        // here if you need to resolve things from the container.
        public void Configure(
          IApplicationBuilder app,
          IApplicationLifetime appLifetime)
        {

            app.UseMvc();
        }
    }
}

