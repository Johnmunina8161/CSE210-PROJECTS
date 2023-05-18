using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
               "What frightened you today?",
               "Who do you wish you had talked to today? What would you say?",
               "What is one thing you want to remember from today?",
               "What steps did you take today towards a goal you’re working on?",
               "What do you need the most right now?",
               "If you could only accomplish three things tomorrow, what would they be?",
               "What was the most peaceful moment during the day?", 
               "What is something that you would like to change about yourself? How can you change it?",
               "How can you know if inspiration is coming from God or your own thoughts?",
               "Why do you keep asking yourself to write down what you are learning?",
               "What active learning techniques will you start to use?",
               "Why is teaching a requirement for disciples of Christ?",
               "Why should payment of tithes and offerings take priority over the payment of living expenses?",
               "How does the self-reliant approach to budgeting help you to become a better steward over your finances?",
               "What blessings have come to you as either a giver or receiver of generous fast offerings?",


            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("A. Write");
                Console.WriteLine("B. Display");
                Console.WriteLine("C. Save");
                Console.WriteLine("D. Load");
                Console.WriteLine("E. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "B":
                        journal.DisplayEntries();
                        break;
                    case "C":
                        journal.SaveToFile();
                        break;
                    case "D":
                        journal.LoadFromFile();
                        break;
                    case "E":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("continue!");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}