﻿namespace IocBattle.Benchmark.Models
{
    public interface IStockQuote
    {
        ILogger Logger { get; }
        IErrorHandler ErrorHandler { get; }
        IDatabase Database { get; }
    }
}