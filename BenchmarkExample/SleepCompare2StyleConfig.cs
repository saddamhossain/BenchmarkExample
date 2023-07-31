using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace BenchmarkExample;

public class SleepCompare2StyleConfig : ManualConfig
{
    public SleepCompare2StyleConfig()
    {
        SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Percentage);
    }
}
