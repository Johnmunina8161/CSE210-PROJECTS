using System;
using System.Collections.Generic;
namespace polymorphysm
{
    class Activity
    {
        private int minutes;

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public virtual string GetSummary()
        {
            return $"Minutes: {minutes}\nDistance: {GetDistance()} km\nSpeed: {GetSpeed()} km/h\nPace: {GetPace()} min/km\n";
        }
    }

}