using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Web
{
    public class TenClassesStartupReflection : BaseStartup
    {
        public TenClassesStartupReflection(IHostingEnvironment env) : base(env) {}

        public override IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var builder = new ContainerBuilder();

            var allDomainTypes = AppDomain.CurrentDomain.Load("TenClasses").GetTypes();
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
    }
}

