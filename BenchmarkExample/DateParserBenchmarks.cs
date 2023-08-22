using BenchmarkDotNet.Attributes;
namespace BenchmarkExample;

// https://benchmarkdotnet.org/articles/overview.html
[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateParserBenchmarks
{
    private const string DateTime = "2019-12-13T16:33:06Z";

    private static readonly DateParser _dateParser = new DateParser();

    [Benchmark(Baseline = true)]
    public void GetYearFromDateTime()
    {
        _dateParser.GetYearFromDateTime(DateTime);
    }

    [Benchmark]
    public void GetYearFromSplit()
    {
        _dateParser.GetYearFromDateTime(DateTime);
    }

    [Benchmark]
    public void GetYearFromSubstring()
    {
        _dateParser.GetYearFromSubstring(DateTime);
    }

    [Benchmark]
    public void GetYearFromSpan()
    {
        _dateParser.GetYearFromSpan(DateTime);
    }

    [Benchmark]
    public void GetYearFromSpanManualConversion()
    {
        _dateParser.GetYearFromSpanManualConversion(DateTime);
    }
}