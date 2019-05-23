``` ini

BenchmarkDotNet=v0.11.5, OS=ubuntu 18.04
Intel Core i7-4710HQ CPU 2.50GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.203
  [Host] : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT
  Core   : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT

Job=Core  Runtime=Core  

```

# 10 classes
|                                                  Method |        Mean |      Error |    StdDev | Rank |
|-------------------------------------------------------- |------------:|-----------:|----------:|-----:|
|                         AppUp_WithoutReflection         |    23.69 ms |  0.8799 ms |  2.594 ms |    1 |
|                                AppUp_Reflection         |    22.78 ms |  0.6586 ms |  1.890 ms |    1 |
|                  AppUp_AutofacReflectionScanner         |    23.87 ms |  0.8789 ms |  2.592 ms |    1 |
|                 AppUp100times_WithoutReflection         | 2,535.33 ms | 33.9110 ms | 31.720 ms |    6 |
|                        AppUp100times_Reflection         | 2,515.10 ms | 26.1995 ms | 23.225 ms |    6 |
|          AppUp100times_AutofacReflectionScanner         | 2,506.02 ms | 24.7155 ms | 23.119 ms |    6 |
|                      1Request_WithoutReflection         |    28.83 ms |  0.7031 ms |  2.073 ms |    2 |
|                             1Request_Reflection         |    29.04 ms |  0.7685 ms |  2.266 ms |    2 |
|               1Request_AutofacReflectionScanner         |    29.84 ms |  0.7769 ms |  2.278 ms |    2 |
|                    100Request_WithoutReflection         |    41.20 ms |  0.9178 ms |  2.677 ms |    3 |
|                           100Request_Reflection         |    42.08 ms |  0.9198 ms |  2.669 ms |    3 |
|             100Request_AutofacReflectionScanner         |    41.86 ms |  0.9072 ms |  2.603 ms |    3 |
|                   1000Request_WithoutReflection         |   118.60 ms |  2.4325 ms |  6.279 ms |    5 |
|                          1000Request_Reflection         |   113.16 ms |  2.2567 ms |  6.547 ms |    4 |
|            1000Request_AutofacReflectionScanner         |   116.58 ms |  2.8249 ms |  8.285 ms |    5 |


# 100 classes
|                                                  Method |        Mean |      Error |    StdDev | Rank |
|-------------------------------------------------------- |------------:|-----------:|----------:|-----:|
|                         AppUp_WithoutReflection         |    28.41 ms |  0.9409 ms |  2.759 ms |    1 |
|                                AppUp_Reflection         |    28.73 ms |  0.9482 ms |  2.796 ms |    1 |
|                  AppUp_AutofacReflectionScanner         |    28.83 ms |  0.8792 ms |  2.565 ms |    1 |
|                 AppUp100times_WithoutReflection         | 2,734.31 ms | 32.3524 ms | 28.680 ms |    6 |
|                        AppUp100times_Reflection         | 2,744.85 ms | 26.5948 ms | 24.877 ms |    6 |
|          AppUp100times_AutofacReflectionScanner         | 2,794.61 ms | 27.1950 ms | 25.438 ms |    7 |
|                      1Request_WithoutReflection         |    43.21 ms |  0.9249 ms |  2.727 ms |    2 |
|                             1Request_Reflection         |    43.77 ms |  0.8977 ms |  2.604 ms |    2 |
|               1Request_AutofacReflectionScanner         |    42.82 ms |  1.0419 ms |  3.039 ms |    2 |
|                    100Request_WithoutReflection         |    72.32 ms |  1.6079 ms |  4.716 ms |    4 |
|                           100Request_Reflection         |    69.46 ms |  1.3637 ms |  2.786 ms |    3 |
|             100Request_AutofacReflectionScanner         |    68.20 ms |  1.3553 ms |  2.512 ms |    3 |
|                   1000Request_WithoutReflection         |   261.55 ms |  4.9465 ms |  5.080 ms |    5 |
|                          1000Request_Reflection         |   261.37 ms |  5.4417 ms |  5.090 ms |    5 |
|            1000Request_AutofacReflectionScanner         |   264.11 ms |  5.0641 ms |  6.028 ms |    5 |