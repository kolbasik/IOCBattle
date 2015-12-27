namespace IocBattle.Benchmark.Models
{
    public class WebService : IWebService
    {
        // Real singleton
        //private static WebService _instance = new WebService(new Authenticator(new Logger(), new ErrorHandler(new Logger()), new Database(new Logger(), new ErrorHandler(new Logger()))),
        //                                   new StockQuote(new Logger(), new ErrorHandler(new Logger()), new Database(new Logger(), new ErrorHandler(new Logger()))));

        //public static WebService Instance { get { return _instance; } }
        //static WebService()
        //{ }

        public WebService(IAuthenticator authenticator, IStockQuote quotes)
        {
            Authenticator = authenticator;
            StockQuote = quotes;
        }

        public IAuthenticator Authenticator { get; }
        public IStockQuote StockQuote { get; }

        public void Execute()
        {
        }
    }
}