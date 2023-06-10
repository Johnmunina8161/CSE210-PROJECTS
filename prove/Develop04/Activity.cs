using System;
using System.Threading;

namespace ActivityProgram
{
    // Base class for all activities
    public abstract class Activity
    {
        protected int duration;

        public void Start()
        {
            DisplayStartingMessage();
            PrepareToBegin();
            PerformActivity();
            DisplayEndingMessage();
        }

        protected abstract void DisplayStartingMessage();

        protected void PrepareToBegin()
        {
            // Pause for several seconds with a spinner animation
            Console.WriteLine("Preparing to begin...");
            Spinner();
            Console.WriteLine();
        }

        protected abstract void PerformActivity();

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("Good job! You have completed the activity.");
            Console.WriteLine("Activity: {0}", GetType().Name);
            Console.WriteLine("Duration: {0} seconds", duration);
            Console.WriteLine();
            // Pause for several seconds
            Spinner();
        }

        protected void Spinner()
        {
            string[] spinners = { "-", "\\", "|", "/" };
            for (int i = 0; i < 10; i++)
            {
                foreach (string spinner in spinners)
                {
                    Console.Write("\r{0} ", spinner);
                    Thread.Sleep(100);
                }
            }
        }
    }
}  