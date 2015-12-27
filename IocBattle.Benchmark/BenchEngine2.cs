using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IocBattle.Benchmark.Models;

namespace IocBattle.Benchmark
{
    public class BenchEngine2
    {
        private readonly IContainer _container;

        public BenchEngine2(IContainer container)
        {
            _container = container;
        }

        public IEnumerable<Benchmark> Start()
        {
            var tests = new Func<IEnumerable<Benchmark>>[]
            {
                () => RunBenchmark(_container.SetupForSingletonTest, "Singleton"),
                () => RunBenchmark(_container.SetupForTransientTest, "Transient")
            };

            foreach (var test in tests)
            {
                GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
                GC.WaitForPendingFinalizers();

                var results = test().ToArray();
                foreach (var result in results)
                {
                    yield return result;
                }
            }
        }

        private IEnumerable<Benchmark> RunBenchmark(Action setupAction, string mode)
        {
            var stopwatch = Stopwatch.StartNew();

            setupAction();

            var benchmark1 = new Benchmark(_container.Name, mode, "Registration", stopwatch.Elapsed);
            yield return benchmark1;

            stopwatch.Restart();
            for (var i = 0; i < 1000000; i++)
            {
                var instance = _container.Resolve<IWebService>();
            }

            var benchmark2 = new Benchmark(_container.Name, mode, "Component resolve", stopwatch.Elapsed);
            yield return benchmark2;

            yield return new Benchmark(_container.Name, mode, "Total", benchmark1.Time + benchmark2.Time);
        }
    }

    public struct Benchmark
    {
        public Benchmark(string name, string mode, string step, TimeSpan time)
        {
            Name = name;
            Mode = mode;
            Step = step;
            Time = time;
        }

        public string Name { get; private set; }
        public string Mode { get; private set; }
        public string Step { get; private set; }
        public TimeSpan Time { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} : {1} : {2} : {3}ms", Name, Mode, Step, Time.TotalMilliseconds);
        }
    }
}