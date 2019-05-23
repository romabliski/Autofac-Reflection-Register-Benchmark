using Autofac;
using Autofac.Extensions.DependencyInjection;
using HundredClasses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Web
{
    public class HundredClassesStartup : BaseStartup
    {
        public HundredClassesStartup(IHostingEnvironment env) : base(env) {}

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
            builder.RegisterType<Class11>().As<IClass11>().InstancePerDependency();
            builder.RegisterType<Class12>().As<IClass12>().InstancePerDependency();
            builder.RegisterType<Class13>().As<IClass13>().InstancePerDependency();
            builder.RegisterType<Class14>().As<IClass14>().InstancePerDependency();
            builder.RegisterType<Class15>().As<IClass15>().InstancePerDependency();
            builder.RegisterType<Class16>().As<IClass16>().InstancePerDependency();
            builder.RegisterType<Class17>().As<IClass17>().InstancePerDependency();
            builder.RegisterType<Class18>().As<IClass18>().InstancePerDependency();
            builder.RegisterType<Class19>().As<IClass19>().InstancePerDependency();
            builder.RegisterType<Class20>().As<IClass20>().InstancePerDependency();
            builder.RegisterType<Class21>().As<IClass21>().InstancePerDependency();
            builder.RegisterType<Class22>().As<IClass22>().InstancePerDependency();
            builder.RegisterType<Class23>().As<IClass23>().InstancePerDependency();
            builder.RegisterType<Class24>().As<IClass24>().InstancePerDependency();
            builder.RegisterType<Class25>().As<IClass25>().InstancePerDependency();
            builder.RegisterType<Class26>().As<IClass26>().InstancePerDependency();
            builder.RegisterType<Class27>().As<IClass27>().InstancePerDependency();
            builder.RegisterType<Class28>().As<IClass28>().InstancePerDependency();
            builder.RegisterType<Class29>().As<IClass29>().InstancePerDependency();
            builder.RegisterType<Class21>().As<IClass21>().InstancePerDependency();
            builder.RegisterType<Class22>().As<IClass22>().InstancePerDependency();
            builder.RegisterType<Class23>().As<IClass23>().InstancePerDependency();
            builder.RegisterType<Class24>().As<IClass24>().InstancePerDependency();
            builder.RegisterType<Class25>().As<IClass25>().InstancePerDependency();
            builder.RegisterType<Class26>().As<IClass26>().InstancePerDependency();
            builder.RegisterType<Class27>().As<IClass27>().InstancePerDependency();
            builder.RegisterType<Class28>().As<IClass28>().InstancePerDependency();
            builder.RegisterType<Class29>().As<IClass29>().InstancePerDependency();
            builder.RegisterType<Class30>().As<IClass30>().InstancePerDependency();
            builder.RegisterType<Class31>().As<IClass31>().InstancePerDependency();
            builder.RegisterType<Class32>().As<IClass32>().InstancePerDependency();
            builder.RegisterType<Class33>().As<IClass33>().InstancePerDependency();
            builder.RegisterType<Class34>().As<IClass34>().InstancePerDependency();
            builder.RegisterType<Class35>().As<IClass35>().InstancePerDependency();
            builder.RegisterType<Class36>().As<IClass36>().InstancePerDependency();
            builder.RegisterType<Class37>().As<IClass37>().InstancePerDependency();
            builder.RegisterType<Class38>().As<IClass38>().InstancePerDependency();
            builder.RegisterType<Class39>().As<IClass39>().InstancePerDependency();
            builder.RegisterType<Class40>().As<IClass40>().InstancePerDependency();
            builder.RegisterType<Class41>().As<IClass41>().InstancePerDependency();
            builder.RegisterType<Class42>().As<IClass42>().InstancePerDependency();
            builder.RegisterType<Class43>().As<IClass43>().InstancePerDependency();
            builder.RegisterType<Class44>().As<IClass44>().InstancePerDependency();
            builder.RegisterType<Class45>().As<IClass45>().InstancePerDependency();
            builder.RegisterType<Class46>().As<IClass46>().InstancePerDependency();
            builder.RegisterType<Class47>().As<IClass47>().InstancePerDependency();
            builder.RegisterType<Class48>().As<IClass48>().InstancePerDependency();
            builder.RegisterType<Class49>().As<IClass49>().InstancePerDependency();
            builder.RegisterType<Class50>().As<IClass50>().InstancePerDependency();
            builder.RegisterType<Class51>().As<IClass51>().InstancePerDependency();
            builder.RegisterType<Class52>().As<IClass52>().InstancePerDependency();
            builder.RegisterType<Class53>().As<IClass53>().InstancePerDependency();
            builder.RegisterType<Class54>().As<IClass54>().InstancePerDependency();
            builder.RegisterType<Class55>().As<IClass55>().InstancePerDependency();
            builder.RegisterType<Class56>().As<IClass56>().InstancePerDependency();
            builder.RegisterType<Class57>().As<IClass57>().InstancePerDependency();
            builder.RegisterType<Class58>().As<IClass58>().InstancePerDependency();
            builder.RegisterType<Class59>().As<IClass59>().InstancePerDependency();
            builder.RegisterType<Class60>().As<IClass60>().InstancePerDependency();
            builder.RegisterType<Class61>().As<IClass61>().InstancePerDependency();
            builder.RegisterType<Class62>().As<IClass62>().InstancePerDependency();
            builder.RegisterType<Class63>().As<IClass63>().InstancePerDependency();
            builder.RegisterType<Class64>().As<IClass64>().InstancePerDependency();
            builder.RegisterType<Class65>().As<IClass65>().InstancePerDependency();
            builder.RegisterType<Class66>().As<IClass66>().InstancePerDependency();
            builder.RegisterType<Class67>().As<IClass67>().InstancePerDependency();
            builder.RegisterType<Class68>().As<IClass68>().InstancePerDependency();
            builder.RegisterType<Class69>().As<IClass69>().InstancePerDependency();
            builder.RegisterType<Class70>().As<IClass70>().InstancePerDependency();
            builder.RegisterType<Class71>().As<IClass71>().InstancePerDependency();
            builder.RegisterType<Class72>().As<IClass72>().InstancePerDependency();
            builder.RegisterType<Class73>().As<IClass73>().InstancePerDependency();
            builder.RegisterType<Class74>().As<IClass74>().InstancePerDependency();
            builder.RegisterType<Class75>().As<IClass75>().InstancePerDependency();
            builder.RegisterType<Class76>().As<IClass76>().InstancePerDependency();
            builder.RegisterType<Class77>().As<IClass77>().InstancePerDependency();
            builder.RegisterType<Class78>().As<IClass78>().InstancePerDependency();
            builder.RegisterType<Class79>().As<IClass79>().InstancePerDependency();
            builder.RegisterType<Class80>().As<IClass80>().InstancePerDependency();
            builder.RegisterType<Class81>().As<IClass81>().InstancePerDependency();
            builder.RegisterType<Class82>().As<IClass82>().InstancePerDependency();
            builder.RegisterType<Class83>().As<IClass83>().InstancePerDependency();
            builder.RegisterType<Class84>().As<IClass84>().InstancePerDependency();
            builder.RegisterType<Class85>().As<IClass85>().InstancePerDependency();
            builder.RegisterType<Class86>().As<IClass86>().InstancePerDependency();
            builder.RegisterType<Class87>().As<IClass87>().InstancePerDependency();
            builder.RegisterType<Class88>().As<IClass88>().InstancePerDependency();
            builder.RegisterType<Class89>().As<IClass89>().InstancePerDependency();
            builder.RegisterType<Class90>().As<IClass90>().InstancePerDependency();
            builder.RegisterType<Class91>().As<IClass91>().InstancePerDependency();
            builder.RegisterType<Class92>().As<IClass92>().InstancePerDependency();
            builder.RegisterType<Class93>().As<IClass93>().InstancePerDependency();
            builder.RegisterType<Class94>().As<IClass94>().InstancePerDependency();
            builder.RegisterType<Class95>().As<IClass95>().InstancePerDependency();
            builder.RegisterType<Class96>().As<IClass96>().InstancePerDependency();
            builder.RegisterType<Class97>().As<IClass97>().InstancePerDependency();
            builder.RegisterType<Class98>().As<IClass98>().InstancePerDependency();
            builder.RegisterType<Class99>().As<IClass99>().InstancePerDependency();
            builder.RegisterType<Class100>().As<IClass100>().InstancePerDependency();

            this.ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(this.ApplicationContainer);
        }
    }
}

