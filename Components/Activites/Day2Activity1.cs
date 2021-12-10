#region License Information

// **********************************************************************************************************************************
// Day2Activity1.cs
// Last Modified: 2021/12/10 5:33 AM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************

#endregion

using System;
using _2021_AdventOfCode.Helpers;
using _2021_AdventOfCode.Properties;

namespace _2021_AdventOfCode.Components.Activites
{
    public class Day2Activity1 : IAmActivity
    {
        #region Public Methods

        public void StartActivity()
        {
            Console.WriteLine("Activity 2-1 started.");
            Console.WriteLine("Processing....");
            var lines = Resources.Activity2_1_Input.GetLinesFromInput();
            var horizontal = 0;
            var vertical = 0;

            foreach (var line in lines)
            {
                var splitCommand = line.Split(null);
                if (splitCommand.Length != 2)
                {
                    throw new Exception("Incorrect size of command");
                }

                if (int.TryParse(splitCommand[1], out var val))
                {
                    switch (splitCommand[0])
                    {
                        case "forward":
                            horizontal += val;
                            break;
                        case "down":
                            vertical += val;
                            break;
                        case "up":
                            vertical -= val;
                            break;
                        default:
                            throw new Exception("Incorrect command");
                            break;
                    }
                }
            }
            Console.WriteLine($"The number of movements is: {lines.Length}");
            Console.WriteLine($"The current horizontal is: {horizontal}");
            Console.WriteLine($"The current vertical is: {vertical}");
            Console.WriteLine($"The product is: {horizontal * vertical}");
        }

        #endregion

        #region IAmActivity

        public string ActivityDescription => Resources.Activity2_1Message;
        public int ActivityDayNumber => 2;
        public int ActivityOrder => 1;

        #endregion
    }

    public class Day2Activity2 : IAmActivity
    {
        #region Public Methods

        public void StartActivity()
        {
            Console.WriteLine("Activity 2-2 started.");
            Console.WriteLine("Processing....");
            var lines = Resources.Activity2_1_Input.GetLinesFromInput();
            var horizontal = 0;
            var vertical = 0;
            var aim  = 0;
            foreach (var line in lines)
            {
                var splitCommand = line.Split(null);
                if (splitCommand.Length != 2)
                {
                    throw new Exception("Incorrect size of command");
                }

                if (int.TryParse(splitCommand[1], out var val))
                {
                    switch (splitCommand[0])
                    {
                        case "forward":
                            horizontal += val;
                            vertical += (aim*val);
                            break;
                        case "down":
                            aim+=val;
                            break;
                        case "up":
                            aim-=val;
                            break;
                        default:
                            throw new Exception("Incorrect command");
                            break;
                    }
                }
            }
            Console.WriteLine($"The number of movements is: {lines.Length}");
            Console.WriteLine($"The current horizontal is: {horizontal}");
            Console.WriteLine($"The current vertical is: {vertical}");
            Console.WriteLine($"The product is: {horizontal * vertical}");
        }

        #endregion

        #region IAmActivity

        public string ActivityDescription => Resources.Activity2_2Message;
        public int ActivityDayNumber => 2;
        public int ActivityOrder => 2;

        #endregion
    }
}