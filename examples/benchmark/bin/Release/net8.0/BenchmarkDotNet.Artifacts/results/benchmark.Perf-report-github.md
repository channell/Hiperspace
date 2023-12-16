```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
Intel Core i9-9980HK CPU 2.40GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method      | Mean          | Error         | StdDev        |
|------------ |--------------:|--------------:|--------------:|
| Load        |            NA |            NA |            NA |
| CountRocks  |            NA |            NA |            NA |
| CountSQL    | 68,922.642 ms | 1,142.2943 ms | 1,068.5028 ms |
| UpdateRocks |            NA |            NA |            NA |
| UpdateSQL   |      5.092 ms |     0.1015 ms |     0.1805 ms |
| JSONRocks   | 72,224.924 ms | 2,116.3461 ms | 6,240.0941 ms |
| JSONSQL     | 78,796.239 ms | 1,508.9653 ms | 1,549.5963 ms |

Benchmarks with issues:
  Perf.Load: DefaultJob
  Perf.CountRocks: DefaultJob
  Perf.UpdateRocks: DefaultJob
