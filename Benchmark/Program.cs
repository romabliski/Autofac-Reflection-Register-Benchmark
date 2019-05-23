using BenchmarkDotNet.Running;
using System;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var small = BenchmarkRunner.Run<TenClassesIocContainerTester>();
            var medium = BenchmarkRunner.Run<HundredClassesIocContainerTester>();
        }
    }
}
