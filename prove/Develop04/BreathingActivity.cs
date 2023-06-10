using System;
using System.Threading;

namespace ActivityProgram
{       
    public class BreathingActivity : Activity
    {
        protected override void DisplayStartingMessage()
        {
            Console.WriteLine("Breathing Activity");
            Console.WriteLine("Description: This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine();
            Console.Write("Enter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        protected override void PerformActivity()
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);

            while (DateTime.Now < futureTime)
            {
                Console.WriteLine("Breathe in...");
                Spinner();
                Console.WriteLine();
                Console.WriteLine("Breathe out...");
                Spinner();
                Console.WriteLine();
            }
        }
    }
}