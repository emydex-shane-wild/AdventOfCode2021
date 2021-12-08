#region License Information

// **********************************************************************************************************************************
// Day1Activity2.cs
// Last Modified: 2021/12/08 9:27 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************

#endregion

using System;

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
        }

        #endregion
    }
}