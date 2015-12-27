namespace IocBattle.Benchmark.Models
{
    public class ErrorHandler : IErrorHandler
    {
        public ErrorHandler(ILogger logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; }
    }
}