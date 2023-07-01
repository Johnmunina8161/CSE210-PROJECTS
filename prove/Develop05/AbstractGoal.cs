using System;

namespace Goaltracker
{
        public abstract class Goal
    {
        // Attributes
        private string _type;
        private string _name;
        private string _description;
        private int _points;

        // Constructors
        public Goal(string type, string name, string description, int points)
        {
            _type = type;
            _name = name;
            _description = description;
            _points = points;
        }

        // Getters and Setters
        public string GetName() { return _name; }

        public string GetDescription() { return _description; }

        public int GetPoints() { return _points; }

        public void SetPoints(int points) { _points = points; }

        // Abstract Methods
        public abstract void ListGoal(int i);

        public abstract string SaveGoal();

        public abstract string LoadGoal();

        public abstract void RecordGoalEvent(List<Goal> goals);
    }
}