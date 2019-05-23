using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;
using Web;

namespace Benchmark
{
    [CoreJob]
    [RPlotExporter, RankColumn]
    public class TenClassesIocContainerTester
    {
        private HttpClient HttpClient;
        private TestServer server;

        [Benchmark]
        public async Task Autofac_AppUp_WithoutReflection()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartup>();
            server = new TestServer(builder);
        }

        [Benchmark]
        public async Task Autofac_AppUp_Reflection()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartupReflection>();
            server = new TestServer(builder);
        }

        [Benchmark]
        public async Task Autofac_AppUp_AutofacReflectionScanner()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartupAutofacReflection>();
            server = new TestServer(builder);
        }

        [Benchmark]
        public async Task Autofac_AppUp100times_WithoutReflection()
        {
            for (int i = 0; i < 100; i++)
            {
                var builder = new WebHostBuilder();
                builder.UseEnvironment("Development");
                builder.UseStartup<TenClassesStartup>();
                server = new TestServer(builder);
            }
        }

        [Benchmark]
        public async Task Autofac_AppUp100times_Reflection()
        {
            for (int i = 0; i < 100; i++)
            {
                var builder = new WebHostBuilder();
                builder.UseEnvironment("Development");
                builder.UseStartup<TenClassesStartupReflection>();
                server = new TestServer(builder);
            }
        }

        [Benchmark]
        public async Task Autofac_AppUp100times_AutofacReflectionScanner()
        {
            for (int i = 0; i < 100; i++)
            {
                var builder = new WebHostBuilder();
                builder.UseEnvironment("Development");
                builder.UseStartup<TenClassesStartupAutofacReflection>();
                server = new TestServer(builder);
            }
        }

        [Benchmark]
        public async Task Autofac_TestRequest1Request_WithoutReflection()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartup>();
            server = new TestServer(builder);

            HttpClient = server.CreateClient();

            var response = await HttpClient.GetAsync("ten/test");
        }

        [Benchmark]
        public async Task Autofac_TestRequest1Request_Reflection()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartupReflection>();
            server = new TestServer(builder);

            HttpClient = server.CreateClient();
            var response = await HttpClient.GetAsync("ten/test");
        }

        [Benchmark]
        public async Task Autofac_TestRequest1Request_AutofacReflectionScanner()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartupAutofacReflection>();
            server = new TestServer(builder);

            HttpClient = server.CreateClient();
            var response = await HttpClient.GetAsync("ten/test");
        }


        [Benchmark]
        public async Task Autofac_TestRequest100Request_WithoutReflection()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartup>();
            server = new TestServer(builder);

            for (int i = 0; i < 100; i++)
            {
                HttpClient = server.CreateClient();
                var response = await HttpClient.GetAsync("ten/test");
            }
        }

        [Benchmark]
        public async Task Autofac_TestRequest100Request_Reflection()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartupReflection>();
            server = new TestServer(builder);

            for (int i = 0; i < 100; i++)
            {
                HttpClient = server.CreateClient();
                var response = await HttpClient.GetAsync("ten/test");
            }
        }

        [Benchmark]
        public async Task Autofac_TestRequest100Request_AutofacReflectionScanner()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartupAutofacReflection>();
            server = new TestServer(builder);

            for (int i = 0; i < 100; i++)
            {
                HttpClient = server.CreateClient();
                var response = await HttpClient.GetAsync("ten/test");
            }
        }

        [Benchmark]
        public async Task Autofac_TestRequest1000Request_WithoutReflection()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartup>();
            server = new TestServer(builder);

            for (int i = 0; i < 1000; i++)
            {
                HttpClient = server.CreateClient();
                var response = await HttpClient.GetAsync("ten/test");
            }
        }

        [Benchmark]
        public async Task AutoFac_TestRequest1000Request_Reflection()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartupReflection>();
            server = new TestServer(builder);

            for (int i = 0; i < 1000; i++)
            {
                HttpClient = server.CreateClient();
                var response = await HttpClient.GetAsync("ten/test");
            }
        }

        [Benchmark]
        public async Task AutoFac_TestRequest1000Request_AutofacReflectionScanner()
        {
            var builder = new WebHostBuilder();
            builder.UseEnvironment("Development");
            builder.UseStartup<TenClassesStartupAutofacReflection>();
            server = new TestServer(builder);

            for (int i = 0; i < 1000; i++)
            {
                HttpClient = server.CreateClient();
                var response = await HttpClient.GetAsync("ten/test");
            }
        }
    }
}
