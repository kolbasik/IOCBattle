namespace IocBattle.Benchmark.Models
{
    public interface IService1
    {
        ILogger Logger { get; }
        IErrorHandler ErrorHandler { get; }
    }

    public interface IService2
    {
        ILogger Logger { get; }
        IErrorHandler ErrorHandler { get; }
    }

    public interface IService3
    {
        ILogger Logger { get; }
        IErrorHandler ErrorHandler { get; }
    }

    public interface IService4
    {
        ILogger Logger { get; }
        IErrorHandler ErrorHandler { get; }
    }

    public class Service1 : IService1
    {
        public Service1(ILogger logger, IErrorHandler handler)
        {
            Logger = logger;
            ErrorHandler = handler;
        }

        public ILogger Logger { get; }
        public IErrorHandler ErrorHandler { get; }
    }

    public class Service2 : IService2
    {
        public Service2(ILogger logger, IErrorHandler handler)
        {
            Logger = logger;
            ErrorHandler = handler;
        }

        public ILogger Logger { get; }
        public IErrorHandler ErrorHandler { get; }
    }

    public class Service3 : IService3
    {
        public Service3(ILogger logger, IErrorHandler handler)
        {
            Logger = logger;
            ErrorHandler = handler;
        }

        public ILogger Logger { get; }
        public IErrorHandler ErrorHandler { get; }
    }

    public class Service4 : IService4
    {
        public Service4(ILogger logger, IErrorHandler handler)
        {
            Logger = logger;
            ErrorHandler = handler;
        }

        public ILogger Logger { get; }
        public IErrorHandler ErrorHandler { get; }
    }
}