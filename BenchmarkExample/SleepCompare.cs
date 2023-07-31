using BenchmarkDotNet.Attributes;

namespace BenchmarkExample;

[Config(typeof(SleepCompareStyleConfig))]
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
