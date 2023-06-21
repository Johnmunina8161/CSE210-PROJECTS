namespace gamification 
{
    // Main program class
    public class Program
    {
        private static List<Goal> goals = new List<Goal>(); // A list that stores instances of the Goal clas & totalScore which holds the cumulative score of the user.
        private static int totalScore = 0;

        private static void Main() //this method is the entry point of the program. It first calls the LoadGoals() method to load any previously saved goals and scores
        {
            LoadGoals(); 

            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("Please select one of the following options: ");
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Display goals");
                Console.WriteLine("4. Display total score");
                Console.WriteLine("5. Save goals and score");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        RecordEvent();
                        break;
                    case "3":
                        DisplayGoals();
                        break;
                    case "4":
                        DisplayTotalScore();
                        break;
                    case "5":
                        SaveGoals();
                        break;
                    case "6":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void CreateGoal()
        {
            Console.WriteLine("Select goal type:");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter points for completing the goal: ");
                    int points = int.Parse(Console.ReadLine());
                    goals.Add(new SimpleGoal(description, points));
                    break;
                case "2":
                    Console.Write("Enter points for each recording of the goal: ");
                    int eternalPoints = int.Parse(Console.ReadLine());
                    goals.Add(new EternalGoal(description, eternalPoints));
                    break;
                case "3":
                    Console.Write("Enter target count for the checklist goal: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter points for each recording of the goal: ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(description, targetCount, checklistPoints));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Goal creation cancelled.");
                    break;
            }

            Console.WriteLine("Goal created successfully.");
        }

        private static void RecordEvent()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals found. Please create a goal first.");
                return;
            }

            Console.WriteLine("Select a goal to record an event:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i]._Description}");
            }

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine()) - 1;

            if (choice >= 0 && choice < goals.Count)
            {
                Goal selectedGoal = goals[choice];
                selectedGoal.Complete();
                Console.WriteLine("Event recorded successfully.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Event recording cancelled.");
            }
        }

        private static void DisplayGoals()
        {
            Console.WriteLine("List of Goals:");

            for (int i = 0; i < goals.Count; i++)
            {
                Goal goal = goals[i];

                Console.Write($"{i + 1}. [{(goal._IsCompleted ? "X" : " ")}] {goal._Description}");

                if (goal is ChecklistGoal checklistGoal)
                {
                    Console.Write($" - {checklistGoal.GetProgressStatus()}");
                }

                Console.WriteLine();
            }
        }

        private static void DisplayTotalScore()
        {
            Console.WriteLine($"Total Score: {totalScore}");
        }

        private static void SaveGoals()
        {
            // Save goals and totalScore to a file or database
            Console.WriteLine("Goals and score saved successfully.");
        }

        private static void LoadGoals()
        {
            // Load goals and totalScore from a file or database
           Console.WriteLine("goals and totalScore Loadged successfully.");
        }
    }
}
