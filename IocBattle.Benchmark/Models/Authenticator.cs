namespace IocBattle.Benchmark.Models
{
    public class Authenticator : IAuthenticator
    {
        public Authenticator(ILogger logger, IErrorHandler handler, IDatabase database)
        {
            Logger = logger;
            ErrorHandler = handler;
            Database = database;
        }

        public ILogger Logger { get; }
        public IErrorHandler ErrorHandler { get; }
        public IDatabase Database { get; }
    }
}