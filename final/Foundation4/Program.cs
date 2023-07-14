using System;
using System.Collections.Generic;

namespace polymorphysm
{
    
    class Program
    {
        static void Main()
        {
            List<Activity> activities = new List<Activity>();

            RunningActivity running = new RunningActivity();
            running.Minutes = 45;
            running.Distance = 10;
            activities.Add(running);

            CyclingActivity cycling = new CyclingActivity();
            cycling.Minutes = 60;
            cycling.Distance = 25;
            activities.Add(cycling);

            SwimmingActivity swimming = new SwimmingActivity();
            swimming.Minutes = 30;
            swimming.Laps = 20;
            activities.Add(swimming);

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
