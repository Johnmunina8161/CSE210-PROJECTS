using System;
namespace Goaltracker
{
    public class EternalGoal : Goal
    {
        // Attributes
        private string _type = "Eternal Goal:";
        private bool _status;

        // Constructors
        public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
        {
            _status = false;
        }

        public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
        {
            _status = status;
        }

        // Methods
        public bool Finished()
        {
            return _status;
        }

        public override void ListGoal(int i)
        {
            if (!Finished())
            {
                Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
            }
            else
            {
                Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
            }
        }

        public override string SaveGoal()
        {
            return $"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}";
        }

        public override string LoadGoal()
        {
            return $"Eternal Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}";
        }

        public override void RecordGoalEvent(List<Goal> goals)
        {
            _status = true;
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points for completing the goal: {GetName()}");
        }
    }
}