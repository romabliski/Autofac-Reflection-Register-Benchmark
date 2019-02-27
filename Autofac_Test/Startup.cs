using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac_Test.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Autofac_Test
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
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

            builder.Populate(services);
            builder.RegisterType<ClassA>().As<IClassA>().InstancePerDependency();
            builder.RegisterType<ClassB>().As<IClassB>().InstancePerDependency();
            builder.RegisterType<ClassC>().As<IClassC>().InstancePerDependency();
            builder.RegisterType<ClassD>().As<IClassD>().InstancePerDependency();
            builder.RegisterType<ClassE>().As<IClassE>().InstancePerDependency();
            builder.RegisterType<ClassF>().As<IClassF>().InstancePerDependency();
            builder.RegisterType<ClassG>().As<IClassG>().InstancePerDependency();
            builder.RegisterType<ClassH>().As<IClassH>().InstancePerDependency();
            builder.RegisterType<ClassI>().As<IClassI>().InstancePerDependency();
            builder.RegisterType<ClassJ>().As<IClassJ>().InstancePerDependency();
            this.ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(this.ApplicationContainer);
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

