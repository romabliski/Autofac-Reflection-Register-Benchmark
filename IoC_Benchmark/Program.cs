using BenchmarkDotNet.Running;
using System;

namespace IoC_Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<IoCTester>();
        }
    }
}
