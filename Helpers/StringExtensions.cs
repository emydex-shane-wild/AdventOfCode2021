#region License Information
// **********************************************************************************************************************************
// StringExtensions.cs
// Last Modified: 2021/12/08 11:21 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************
#endregion

using System;

namespace _2021_AdventOfCode.Helpers
{
    public static class StringExtensions
    {
        public static string[] GetLinesFromInput(this string input)
        {
            return input.Split(new []{Environment.NewLine}, StringSplitOptions.None);
        }
    }
}