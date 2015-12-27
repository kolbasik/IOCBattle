namespace IocBattle.Benchmark.Models
{
    public class StockQuote : IStockQuote
    {
        public StockQuote(ILogger logger, IErrorHandler handler, IDatabase database)
        {
            Logger = logger;
            ErrorHandler = handler;
            Database = database;
        }

        public ILogger Logger { get; }
        public IErrorHandler ErrorHandler { get; }
        public IDatabase Database { get; }

        #region Behavior

        #endregion
    }
}