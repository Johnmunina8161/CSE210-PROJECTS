using System;
namespace Goaltracker
{
    public class ChecklistGoal : Goal
    {
        // Attributes
        private string _type = "Check List Goal:";
        private bool _status;
        private int _numberTimes;
        private int _bonusPoints;
        private int _count;

        // Constructors
        public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints) : base(type, name, description, points)
        {
            _status = false;
            _numberTimes = numberTimes;
            _bonusPoints = bonusPoints;
            _count = 0;
        }

        public ChecklistGoal(string type, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int count) : base(type, name, description, points)
        {
            _status = status;
            _numberTimes = numberTimes;
            _bonusPoints = bonusPoints;
            _count = count;
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
            return $"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {_numberTimes}; {_bonusPoints}; {_count}";
        }

        public override string LoadGoal()
        {
            return $"Check List Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {_numberTimes}; {_bonusPoints}; {_count}";
        }

        public override void RecordGoalEvent(List<Goal> goals)
        {
            _count++;
            if (_count >= _numberTimes)
            {
                _status = true;
                int points = GetPoints() + _bonusPoints;
                Console.WriteLine($"Congratulations! You have earned {points} points for completing the goal: {GetName()}");
            }
            else
            {
                Console.WriteLine($"Goal progress recorded for: {GetName()}");
            }

           // SetPoints(points);
        }
    }

}