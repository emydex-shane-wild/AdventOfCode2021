using System;
using System.Collections.Generic;
using System.Linq;
using _2021_AdventOfCode.Components.AdventDays;
using _2021_AdventOfCode.Properties;

namespace _2021_AdventOfCode.Infrastructure
{
    public interface IApplicationStarter
    {
        void Begin();
    }

    public class ApplicationStarter : IApplicationStarter
    {
        private readonly IEnumerable<IAmAdventDay> _adventDays;

        public ApplicationStarter(IEnumerable<IAmAdventDay> adventDays)
        {
            _adventDays = adventDays;
        }

        #region Implementation of IStartApplication

        public void Begin()
        {
            Console.WriteLine(Resources.WelcomeMessage + System.Environment.NewLine);

            if(_adventDays?.Any() != true)
            {            
                Console.WriteLine(Resources.MissingAdventDays);
                Console.ReadKey();
            }

            var maxAdventDay = _adventDays.Max(d => d.AdventDayNumber);
            
            var retry = true;
            while(retry)
            {
                retry = false;           
                Console.WriteLine($"{Resources.GettingStartedMessage}{maxAdventDay}");
                var input = Console.ReadLine();
                if(int.TryParse(input, out var dayNumber) && dayNumber > 0 && dayNumber <= maxAdventDay)
                {
                    var adventDay = _adventDays.FirstOrDefault(d => d.AdventDayNumber == dayNumber);
                    if(adventDay == null)
                    {
                        Console.WriteLine(Resources.LostAdventDay);
                    }else
                    {                   
                        Console.WriteLine($"{Resources.WelcomeToDayMessage}{adventDay.AdventDayNumber}");
                        var activitiesForDay = adventDay.DailyActivities().ToArray();
                        if(activitiesForDay?.Any() != true)
                        {
                            Console.WriteLine(Resources.LostAdventDay);
                        }else
                        {
                            var maxActivityNumber = activitiesForDay.Max(a => a.ActivityOrder);
                            Console.WriteLine($"{Resources.DayActivitiesMessage}{maxActivityNumber}");
                            var activityInput = Console.ReadLine();
                            if(int.TryParse(activityInput, out var activityNumber) && activityNumber > 0 && activityNumber <= maxActivityNumber)
                            {
                                var activity = activitiesForDay.FirstOrDefault(a => a.ActivityOrder == activityNumber);
                                if(activity == null)
                                {
                                    Console.WriteLine($"{Resources.LostActivity}");
                                }else
                                {
                                    Console.WriteLine($"{Resources.WelcomeToActivityMessage}{activity.ActivityDayNumber}-{activity.ActivityOrder}");
                                    Console.WriteLine(activity.ActivityDescription);
                                    activity.StartActivity();
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{Resources.InvalidActivityDay}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine(Resources.InvalidAdventDay);
                }

                Console.WriteLine(Resources.RetryMessage);
                var retryOption = Console.ReadKey();
                retry = retryOption.Key != ConsoleKey.X;
                Console.WriteLine();
            }
        }

        #endregion
    }
}