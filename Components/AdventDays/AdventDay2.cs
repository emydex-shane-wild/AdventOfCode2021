#region License Information

// **********************************************************************************************************************************
// AdventDay2.cs
// Last Modified: 2021/12/10 5:12 AM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************

#endregion

using System.Collections.Generic;
using _2021_AdventOfCode.Components.Activites;

namespace _2021_AdventOfCode.Components.AdventDays
{
    public class AdventDay2 : AdventDayBase
    {
        public AdventDay2(IEnumerable<IAmActivity> activities) : base(activities) { }

        #region Overrides of AdventDayBase

        protected override int GetAdventDay() => 2;

        #endregion
    }
}