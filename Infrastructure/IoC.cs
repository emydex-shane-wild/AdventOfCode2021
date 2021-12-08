using System.Reflection;
using Autofac;

namespace _2021_AdventOfCode.Infrastructure
{
    public static class IoC
    {
        public static IContainer Container { get; private set; }

        public static void Initialise()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(Assembly.GetAssembly(typeof(IoC)));
            Container = builder.Build();
        }
    }
}