using System;
using System.Collections.Generic;
namespace Goaltracker
{
    public class Program
    {
        private static GoalManagement _goalManagement;

        public static void Main(string[] args)
        {
            _goalManagement = new GoalManagement();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Goal Management Program");
                Console.WriteLine("1. Add Goal");
                Console.WriteLine("2. Record Goal Event");
                Console.WriteLine("3. List Goals");
                Console.WriteLine("4.  Calculate Total Points");
                Console.WriteLine("5. Save Goals to File");
                Console.WriteLine("6. Load Goals from File");
                Console.WriteLine("7. Exit");
                Console.Write("Enter option: ");

                string option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        AddGoal();
                        break;
                    case "2":
                        RecordGoalEvent();
                        break;
                    case "3":
                        ListGoals();
                        break;
                    case "4":
                        CalculateTotalPoints();
                        break;
                    case "5":
                        SaveGoalsToFile();
                        break;
                    case "6":
                        LoadGoalsFromFile();
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();
            }
        }

        public static void AddGoal()
        {
            Console.Write("Enter goal type (Checklist/Eternal): ");
            string goalType = Console.ReadLine();
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter goal points: ");
            int points = int.Parse(Console.ReadLine());

            if (goalType == "Checklist")
            {
                Console.Write("Enter number of times goal needs to be completed: ");
                int numberTimes = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                Goal goal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                _goalManagement.AddGoal(goal);
            }
            else if (goalType == "Eternal")
            {
                Goal goal = new EternalGoal("Eternal Goal:", name, description, points);
                _goalManagement.AddGoal(goal);
            }
            else
            {
                Console.WriteLine("Invalid goal type.");
            }

            Console.WriteLine("Goal added.");
        }

        public static void RecordGoalEvent()
        {
            Console.Write("Enter goal index: ");
            int goalIndex = int.Parse(Console.ReadLine());
            _goalManagement.RecordGoalEvent(goalIndex);
        }

        public static void ListGoals()
        {
            _goalManagement.ListGoals();
        }

        public static void CalculateTotalPoints()
        {
            int totalPoints = _goalManagement.CalculateTotalPoints();
            Console.WriteLine($"Total points: {totalPoints}");
        }

        public static void SaveGoalsToFile()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();
            _goalManagement.SaveGoalsToFile(filePath);
        }

        public static void LoadGoalsFromFile()
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();
            _goalManagement.LoadGoalsFromFile(filePath);
        }
    }
}