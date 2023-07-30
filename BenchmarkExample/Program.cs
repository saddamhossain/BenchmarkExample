using BenchmarkDotNet.Running;
using BenchmarkExample;

//BenchmarkRunner.Run<DateParserBenchmarks>();

//BenchmarkRunner.Run<IntroBenchmarkBaseline>();

BenchmarkRunner.Run<SleepCompare>();

Console.ReadKey();
