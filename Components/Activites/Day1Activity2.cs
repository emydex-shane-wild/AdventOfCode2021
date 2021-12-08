#region License Information

// **********************************************************************************************************************************
// Day1Activity2.cs
// Last Modified: 2021/12/08 9:27 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using _2021_AdventOfCode.Helpers;

namespace _2021_AdventOfCode.Components.Activites
{
    public class Day1Activity2 : IAmActivity
    {
        #region Implementation of IAmActivity

        public int ActivityDayNumber => 1;
        public int ActivityOrder => 2;
        public void StartActivity()
        {
            Console.WriteLine("Activity 1-2 started.");
            Console.WriteLine("Processing....");
            var lines = Properties.Resources.Activity1_1_Input.GetLinesFromInput();
            //var lines = $"199 {System.Environment.NewLine} 200 {System.Environment.NewLine} 208 {System.Environment.NewLine} 210 {System.Environment.NewLine} 200 {System.Environment.NewLine} 207 {System.Environment.NewLine} 240 {System.Environment.NewLine} 269 {System.Environment.NewLine} 260 {System.Environment.NewLine} 263".GetLinesFromInput();
            var totalLines = lines.Length;
            
            var windowSums = new Queue<int>();
            for(var i = 0; i < totalLines; i++)
            {
                var idx1 = i;
                var idx2 = i+1;
                var idx3 = i+2;

                if(idx3 <= (totalLines - 1) &&
                   int.TryParse(lines[idx1], out var val1) &&
                   int.TryParse(lines[idx2], out var val2) &&
                   int.TryParse(lines[idx3], out var val3))
                {
                    var total = val1 + val2 + val3;
                    windowSums.Enqueue(total);
                }
            }
            var totalWindowSums = windowSums.Count;
            var isFirst = true;
            var incrementedCount = 0;
            var lastValue = 0;
            while (windowSums.Count != 0)
            {
                var val = windowSums.Dequeue();
                if(isFirst)
                {
                    isFirst = false;
                }else
                {
                    if(val > lastValue)
                    {
                        incrementedCount++;
                    }
                }

                lastValue = val;
            }
            
            Console.WriteLine($"The number of three-measurement windows is: {totalWindowSums}");
            Console.WriteLine($"The number of three-measurement windows larger than the previous is: {incrementedCount}");
        }

        #endregion
    }
}