using System;
using System.Collections.Generic;
namespace polymorphysm
{
    
    class SwimmingActivity : Activity
    {
        private int laps;

        public int Laps
        {
            get { return laps; }
            set { laps = value; }
        }

        public override double GetDistance()
        {
            return laps * 50 / 1000;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"Swimming Activity\nLaps: {laps}\n{base.GetSummary()}";
        }
    }

}