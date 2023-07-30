using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkExample;

[Config(typeof(StyleConfig2))]
public class SleepCompare2
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