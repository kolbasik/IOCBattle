namespace IocBattle.Benchmark.Models
{
    public interface IDatabase
    {
        ILogger Logger { get; }
        IErrorHandler ErrorHandler { get; }
    }
}