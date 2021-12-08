#region License Information

// **********************************************************************************************************************************
// AdventDayModule.cs
// Last Modified: 2021/12/08 9:28 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************

#endregion

using System.Linq;
using _2021_AdventOfCode.Components.Activites;
using _2021_AdventOfCode.Components.AdventDays;
using _2021_AdventOfCode.Infrastructure;
using Autofac;

namespace _2021_AdventOfCode.Modules
{
    public class AdventDayModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var adventDays = typeof(IAmAdventDay).Assembly.GetTypes().Where(t => t.IsClass && 
                                                                                     t.IsAbstract == false && 
                                                                                     TypeExtensions.IsAssignableTo<IAmAdventDay>(t)).ToArray();
            builder.RegisterTypes(adventDays).SingleInstance().AsImplementedInterfaces();

            var adventActivities = typeof(IAmActivity).Assembly.GetTypes().Where(t => t.IsClass && 
                                                                                     t.IsAbstract == false && 
                                                                                     TypeExtensions.IsAssignableTo<IAmActivity>(t)).ToArray();
            builder.RegisterTypes(adventActivities).SingleInstance().AsImplementedInterfaces();
        }
    }
}