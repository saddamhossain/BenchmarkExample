using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace BenchmarkExample;

public class StyleConfig2 : ManualConfig
{
    public StyleConfig2()
    {
        SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Percentage);
    }
}
