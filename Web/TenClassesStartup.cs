using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TenClasses;
using System;

namespace Web
{
    public class TenClassesStartup : BaseStartup
    {
        public TenClassesStartup(IHostingEnvironment env) : base(env) {}

        public override IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var builder = new ContainerBuilder();

            builder.Populate(services);
            builder.RegisterType<Class1>().As<IClass1>().InstancePerDependency();
            builder.RegisterType<Class2>().As<IClass2>().InstancePerDependency();
            builder.RegisterType<Class3>().As<IClass3>().InstancePerDependency();
            builder.RegisterType<Class4>().As<IClass4>().InstancePerDependency();
            builder.RegisterType<Class5>().As<IClass5>().InstancePerDependency();
            builder.RegisterType<Class6>().As<IClass6>().InstancePerDependency();
            builder.RegisterType<Class7>().As<IClass7>().InstancePerDependency();
            builder.RegisterType<Class8>().As<IClass8>().InstancePerDependency();
            builder.RegisterType<Class9>().As<IClass9>().InstancePerDependency();
            builder.RegisterType<Class10>().As<IClass10>().InstancePerDependency();
            this.ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(this.ApplicationContainer);
        }
    }
}

