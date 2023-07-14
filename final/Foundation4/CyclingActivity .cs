using System;
using System.Collections.Generic;
namespace polymorphysm
{
    class CyclingActivity : Activity
    {
        private double distance;

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return (distance / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / distance;
        }

        public override string GetSummary()
        {
            return $"Cycling Activity\n{base.GetSummary()}";
        }
    }

}