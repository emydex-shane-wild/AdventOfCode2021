#region License Information
// **********************************************************************************************************************************
// Day1Activity1.cs
// Last Modified: 2021/12/08 9:22 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************
#endregion

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using _2021_AdventOfCode.Helpers;

namespace _2021_AdventOfCode.Components.Activites
{
    public class Day1Activity1 : IAmActivity
    {
        #region Implementation of IAmActivity

        public int ActivityDayNumber => 1;
        public int ActivityOrder => 1;
        public void StartActivity()
        {
            Console.WriteLine("Activity 1-1 started.");
            Console.WriteLine("Processing....");
            var lines = Properties.Resources.Activity1_1_Input.GetLinesFromInput();
            var isFirst = true;
            var lastValue = 0;
            var incrementedCount = 0;
            foreach (var line in lines)
            {
                if(int.TryParse(line, out var value))
                {
                    if(isFirst)
                    {
                        isFirst = false;
                    }else
                    {
                        if(value > lastValue)
                        {
                            incrementedCount++;
                        }
                    }
                    lastValue = value;
                }
            }
            Console.WriteLine($"The number of depth measurements is: {lines.Length}");
            Console.WriteLine($"The number of depth measurements larger than the previous is: {incrementedCount}");
        }

        

        #endregion
    }
}