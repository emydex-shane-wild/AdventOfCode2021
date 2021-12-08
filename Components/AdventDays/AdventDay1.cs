#region License Information

// **********************************************************************************************************************************
// AdventDay1.cs
// Last Modified: 2021/12/08 9:20 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************

#endregion

using System.Collections.Generic;
using _2021_AdventOfCode.Components.Activites;

namespace _2021_AdventOfCode.Components.AdventDays
{
    public class AdventDay1 : AdventDayBase
    {
        public AdventDay1(IEnumerable<IAmActivity> activities) : base(activities) { }

        #region Overrides of AdventDayBase

        protected override int GetAdventDay() => 1;

        #endregion
    }
}