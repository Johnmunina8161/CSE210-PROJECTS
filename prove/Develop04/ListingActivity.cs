using System;
using System.Threading;

namespace ActivityProgram
{        
    public class ListingActivity : Activity
    {
        private string[] prompts = 
        {   "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        protected override void DisplayStartingMessage()
        {
            Console.WriteLine("Listing Activity");
            Console.WriteLine("Description: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine();
            Console.Write("Enter duration in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        protected override void PerformActivity()
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);
            Random random = new Random();

            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Spinner();
            Console.WriteLine();

            Console.WriteLine("Start listing items:");
            int itemCount = 0;
            while (DateTime.Now < futureTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                itemCount++;
            }

            Console.WriteLine();
            Console.WriteLine("Number of items listed: {0}", itemCount);
        
        }   
            
    } 
}       