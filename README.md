``` ini

BenchmarkDotNet=v0.11.4, OS=Windows 8.1 (6.3.9600.0)
Unknown processor
Frequency=2435768 Hz, Resolution=410.5481 ns, Timer=TSC
.NET Core SDK=2.1.500
  [Host] : .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT  [AttachedDebugger]
  Core   : .NET Core 2.1.6 (CoreCLR 4.6.27019.06, CoreFX 4.6.27019.05), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|                                           Method |        Mean |      Error |     StdDev | Rank |
|------------------------------------------------- |------------:|-----------:|-----------:|-----:|
|                  Autofac_AppUp_WithoutReflection |    27.47 ms |  0.5462 ms |   1.477 ms |    1 |
|                         Autofac_AppUp_Reflection |    27.88 ms |  0.5843 ms |   1.686 ms |    1 |
|          Autofac_AppUp100times_WithoutReflection | 3,331.82 ms | 69.8822 ms | 106.717 ms |    6 |
|                 Autofac_AppUp100times_Reflection | 3,642.54 ms | 81.2130 ms | 218.173 ms |    7 |
|    Autofac_TestRequest1Request_WithoutReflection |    33.96 ms |  0.7661 ms |   2.247 ms |    2 |
|           Autofac_TestRequest1Request_Reflection |    33.69 ms |  0.7249 ms |   2.115 ms |    2 |
|  Autofac_TestRequest100Request_WithoutReflection |    45.74 ms |  0.8822 ms |   1.265 ms |    3 |
|         Autofac_TestRequest100Request_Reflection |    47.08 ms |  0.9313 ms |   1.631 ms |    4 |
| Autofac_TestRequest1000Request_WithoutReflection |   147.24 ms |  2.3166 ms |   2.167 ms |    5 |
|                TestRequest1000Request_Reflection |   146.68 ms |  1.9856 ms |   1.760 ms |    5 |
