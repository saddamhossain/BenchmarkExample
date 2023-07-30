namespace BenchmarkExample;

// 2019-12-13T16:33:06Z
public class DateParser
{
    public int GetYearFromDateTime(string dateTimeAsString)
    {
        var dateTime = DateTime.Parse(dateTimeAsString);
        return dateTime.Year;
    }

    public int GetYearFromSplit(string dateTimeAsString)
    {
        var splitOnHiphen = dateTimeAsString.Split('-');
        return int.Parse(splitOnHiphen[0]);
    }

    public int GetYearFromSubstring(string dateTimeAsString)
    {
        var indexOfHiphen = dateTimeAsString.IndexOf('-');
        return int.Parse(dateTimeAsString.Substring(0, indexOfHiphen));
    }

    public int GetYearFromSpan(ReadOnlySpan<char> dateTimeSpan)
    {
        var indexOfHiphen = dateTimeSpan.IndexOf('-');
        return int.Parse(dateTimeSpan.Slice(0, indexOfHiphen));
    }

    public int GetYearFromSpanManualConversion(ReadOnlySpan<char> dateTimeSpan)
    {
        var indexOfHiphen = dateTimeSpan.IndexOf('-');
        var yearAsSpan = dateTimeSpan.Slice(0, indexOfHiphen);

        var temp = 0;
        for (int i = 0; i < yearAsSpan.Length; i++)
        {
            temp = temp * 10 + (yearAsSpan[i] - '0');
        }
        return temp;
    }
}
