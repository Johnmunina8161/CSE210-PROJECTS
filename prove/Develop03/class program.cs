using System;

namespace ScriptureHiderWords
{
    class Programss
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Scripture class
            Scripture scripture = new Scripture(new Reference("Luke", 19, 41),"As Jesus approached Jerusalem and...");
            Console.Clear();
            scripture.Display();

            while (true)
            {
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input == "quit")
                    break;

                Console.Clear();
                scripture.HideRandomWord();
                scripture.Display();

                if (scripture.AllWordsHidden())
                    break;
            }
        }
    }
  
}
