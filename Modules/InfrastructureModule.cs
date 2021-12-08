#region License Information
// **********************************************************************************************************************************
// InfrastructureModule.cs
// Last Modified: 2021/12/08 9:09 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************
#endregion

using _2021_AdventOfCode.Components;
using _2021_AdventOfCode.Infrastructure;
using Autofac;

namespace _2021_AdventOfCode.Modules
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(ApplicationStarter)).SingleInstance().AsImplementedInterfaces();
        }
    }
}