#region License Information

// **********************************************************************************************************************************
// IAmActivity.cs
// Last Modified: 2021/12/08 9:27 PM
// Last Modified By: Shane Wild
// Copyright Emydex Technology Ltd @2021
// **********************************************************************************************************************************

#endregion

namespace _2021_AdventOfCode.Components.Activites
{
    public interface IAmActivity
    {
        int ActivityDayNumber {get;}
        int ActivityOrder {get;}
        void StartActivity();
    }
}