namespace IocBattle.Benchmark.Models
{
    public class Database : IDatabase
    {
        public Database(ILogger logger, IErrorHandler handler)
        {
            Logger = logger;
            ErrorHandler = handler;
        }

        public ILogger Logger { get; }
        public IErrorHandler ErrorHandler { get; }
    }
}