﻿using BenchmarkDotNet.Attributes;

namespace BenchmarkExample;

public class IntroBenchmarkBaseline
{
    [Benchmark]
    public static void Time50()
    {
        Thread.Sleep(50);
    }


    [Benchmark(Baseline =true)]
    public void Time100()
    {
        Thread.Sleep(100);
    }


    [Benchmark]
    public void Time150()
    {
        Thread.Sleep(150);
    }

}
