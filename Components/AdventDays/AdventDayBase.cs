#region License Information
// **********************************************************************************************************************************
// IAmAdventDay.cs
// Last Modified: 2021/12/08 9:16 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _2021_AdventOfCode.Components.Activites;

namespace _2021_AdventOfCode.Components.AdventDays
{
    public interface IAmAdventDay
    {
        IEnumerable<IAmActivity> DailyActivities();
        int AdventDayNumber {get;}
    }

    public abstract class AdventDayBase : IAmAdventDay
    {
        private readonly IEnumerable<IAmActivity> _dailyActivities;

        protected AdventDayBase(IEnumerable<IAmActivity> activities)
        {
            _dailyActivities = activities.Where(a => a.ActivityDayNumber == AdventDayNumber);
        }

        protected abstract int GetAdventDay();
        public int AdventDayNumber => GetAdventDay();

        #region Implementation of IAmAdventDay

        public IEnumerable<IAmActivity> DailyActivities()
        {
            return _dailyActivities;
        }

        #endregion
    }
}