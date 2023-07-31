using BenchmarkDotNet.Attributes;

namespace BenchmarkExample;

[Config(typeof(SleepCompare2StyleConfig))]
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