using System;
using System.Threading;

namespace FoodDelivery
{
    // Base class for all food delivery activities
    public abstract class DeliveryActivity
    {
        protected string activityName;

        protected DeliveryActivity(string activityName)
        {
            this.activityName = activityName;
        }

        public void PerformActivity()
        {
            Console.WriteLine($"Starting {activityName}...");
            Prepare();
            Console.WriteLine("Activity in progress...");

            DoActivity();

            Console.WriteLine($"Completed {activityName}!");
            Console.WriteLine();
        }

        protected abstract void Prepare();
        protected abstract void DoActivity();
    }
}   
