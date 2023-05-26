using System;

namespace ScriptureHider


{
    class Program
    {
        static void Main()
        {
               Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world...");

               Console.Clear();
               scripture.Display();
               Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        
            while (true)
            {
               string input = Console.ReadLine();
               if (input.ToLower() == "quit")
                    break;

               scripture.HideRandomWord();
               Console.Clear();
               scripture.Display();
               Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}