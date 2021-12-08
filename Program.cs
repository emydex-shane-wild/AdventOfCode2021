using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2021_AdventOfCode.Infrastructure;
using Autofac;
using Autofac.Core;

namespace _2021_AdventOfCode
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            IoC.Initialise();
            var appStarter = IoC.Container.Resolve<IApplicationStarter>();
            appStarter?.Begin();
        }
    }
}
