``` ini

BenchmarkDotNet=v0.11.4, OS=Windows 8.1 (6.3.9600.0)
Unknown processor
Frequency=2435768 Hz, Resolution=410.5481 ns, Timer=TSC
.NET Core SDK=2.1.500
  [Host] : .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT  [AttachedDebugger]
  Core   : .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|                                           Method |      Mean |     Error |   StdDev |    Median | Rank |
|------------------------------------------------- |----------:|----------:|---------:|----------:|-----:|
|                  Autofac_AppUp_WithoutReflection |  27.34 ms | 0.5424 ms | 1.521 ms |  27.08 ms |    1 |
|                         Autofac_AppUp_Reflection |  27.28 ms | 0.5932 ms | 1.673 ms |  27.02 ms |    1 |
|    Autofac_TestRequest1Request_WithoutReflection |  33.84 ms | 0.8161 ms | 2.368 ms |  33.52 ms |    2 |
|           Autofac_TestRequest1Request_Reflection |  34.46 ms | 0.8155 ms | 2.392 ms |  34.30 ms |    2 |
|  Autofac_TestRequest100Request_WithoutReflection |  47.29 ms | 0.9450 ms | 2.300 ms |  46.55 ms |    4 |
|         Autofac_TestRequest100Request_Reflection |  45.81 ms | 0.9007 ms | 1.578 ms |  45.58 ms |    3 |
| Autofac_TestRequest1000Request_WithoutReflection | 144.78 ms | 2.8228 ms | 2.640 ms | 145.53 ms |    5 |
|                TestRequest1000Request_Reflection | 145.51 ms | 2.8344 ms | 3.150 ms | 144.79 ms |    5 |
