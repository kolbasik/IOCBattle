using System;
using StructureMap;

namespace IocBattle.Benchmark.StructureMap
{
    public static class ObjectFactory
    {
        public static Container Container { get; private set; }

        public static void Initialize(Action<ConfigurationExpression> cfg)
        {
            Container = new Container(cfg);
        }

        public static void Dispose()
        {
            Container?.Dispose();
        }
    }
}