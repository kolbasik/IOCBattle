using System;
using System.Collections.Generic;
using IocBattle.Benchmark.Tests;

namespace IocBattle.Benchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var containers = new IContainer[]
            {
                new NewContainer(),
                new DynamoAutoContainer(),
                new AutoFacLambdaContainer(),
                new AutoFacContainer(),
                new StructureMapContainer(),
                new SimpleInjectorContainer(),
                new UnityContainer(),
                new NinjectContainer(),
                new WindsorContainer()
            };

            var benchmarks = new List<Benchmark>();
            foreach (var container in containers)
            {
                var runner = new BenchEngine2(container);
                var results = runner.Start();
                foreach (var result in results)
                {
                    Console.WriteLine(result);
                    benchmarks.Add(result);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey(true);
        }
    }
}