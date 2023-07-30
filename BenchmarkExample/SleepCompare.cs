﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace BenchmarkExample;

[Config(typeof(StyleConfig))]
public class SleepCompare
{

    [Benchmark(Baseline = true)]
    public void Baseline()
    {
        Thread.Sleep(1000);
    }

    [Benchmark]
    public void Bar()
    {
        Thread.Sleep(150);
    }

    [Benchmark]
    public void Foo()
    {
        Thread.Sleep(1150);
    }
}
