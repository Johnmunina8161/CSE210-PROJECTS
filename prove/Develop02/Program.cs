using System;
using System.Collections.Generic;
using System.IO;

namespace DailyJournal;
class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            // List of prompts
            List<string> prompts = new List<string>
            {
                "what is your first name? ",
                "What is your last name? ",
                "How was your day? ",
                "how did you feel after prayer? ",
                "What is your favorite color? ",
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nDaily Journal Menu");
                Console.WriteLine("------------");
                Console.WriteLine("A. new entry");
                Console.WriteLine("B. Display journal");
                Console.WriteLine("C. Save the journal to a file");
                Console.WriteLine("D. Load the journal from a file");
                Console.WriteLine("E. Quit");

                Console.Write("\nEnter your choice from (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                        journal.AddEntry(prompts[new Random().Next(prompts.Count)]);
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
            }   Console.WriteLine();
        } 

    }
                            // Diagram  Program

  /*
                            +-----------------+
                            |     Program     |
                            +-----------------+
                            |   - journal     |
                            +-----------------+
                                    |
                                    |
                                    |
                        +-----------+-----------+
                        |                       |
                 +------+--------+      +-------+-----+
                 |  PromptList   |      |     Entry   |
                 +---------------+      +-------------+
                 | -prompts      |      | -prompt     |
                 |               |      | -response   |
                 | +get_prompt() |      | -date       |
                 +---------------+      +-------------+
                                    |
                                    |
                      +-------------+-------------+
                      |             |             |
            +---------+-----+ +-----+---------+ +------------+
            |   SaveToFile  | |  LoadFromFile | |  Display   |
            +---------------+ +---------------+ +------------+
            | -filename     | | -filename     | | -journal   |
            |               | |               | |            |
            | +save()       | | +load()       | | +display() |
            +---------------+ +---------------+ +------------+     */    

