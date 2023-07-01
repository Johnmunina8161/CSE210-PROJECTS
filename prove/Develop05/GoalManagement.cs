namespace Goaltracker
{
    public class GoalManagement
    {
        private List<Goal> _goals;

        public GoalManagement()
        {
            _goals = new List<Goal>();
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordGoalEvent(int goalIndex)
        {
            if (goalIndex > 0 && goalIndex <= _goals.Count)
            {
                Goal goal = _goals[goalIndex - 1];
                goal.RecordGoalEvent(_goals);
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public void ListGoals()
        {
            Console.WriteLine("Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                goal.ListGoal(i + 1);
            }
        }

        public int CalculateTotalPoints()
        {
            int totalPoints = _goals.Sum(goal => goal.GetPoints());
            return totalPoints;
        }

        public void SaveGoalsToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Goal goal in _goals)
                {
                    string goalString = goal.SaveGoal();
                    writer.WriteLine(goalString);
                }
            }

            Console.WriteLine($"Goals saved to file: {filePath}");
        }

        public void LoadGoalsFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                _goals.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] goalAttributes = line.Split(';');

                        string goalType = goalAttributes[0];
                        if (goalType == "Check List Goal:")
                        {
                            string name = goalAttributes[1];
                            string description = goalAttributes[2];
                            int points = int.Parse(goalAttributes[3]);
                            bool status = bool.Parse(goalAttributes[4]);
                            int numberTimes = int.Parse(goalAttributes[5]);
                            int bonusPoints = int.Parse(goalAttributes[6]);
                            int count = int.Parse(goalAttributes[7]);
                            Goal goal = new ChecklistGoal(goalType, name, description, points, status, numberTimes, bonusPoints, count);
                            _goals.Add(goal);
                        }
                        else if (goalType == "Eternal Goal:")
                        {
                            string name = goalAttributes[1];
                            string description = goalAttributes[2];
                            int points = int.Parse(goalAttributes[3]);
                            bool status = bool.Parse(goalAttributes[4]);
                            Goal goal = new EternalGoal(goalType, name, description, points, status);
                            _goals.Add(goal);
                        }
                    }
                }

                Console.WriteLine($"Goals loaded from file: {filePath}");
            }
            else
            {
                Console.WriteLine($"File not found: {filePath}");
            }
        }
    }
}