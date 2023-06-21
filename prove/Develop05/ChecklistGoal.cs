namespace gamification 
{
    // Checklist goal class
    public class ChecklistGoal : Goal //class inherits from the Goal class. This means that it inherits all of the functionality of the Goal class, such as a description, a completion status, and a score.
    {
        private int targetCount; // this field stores the target number of times that the goal must be completed.
        private int points; // the number of points that are awarded when the goal is completed.
        private int currentCount; //  the current number of times that the goal has been completed.

        public ChecklistGoal(string description, int targetCount, int points) : base(description) //  constructor initializes the goal with the given description, target count, and points.
        {
            this.targetCount = targetCount;
            this.points = points;
            currentCount = 0;
        }

        public override void Complete() // This method is used to complete the goal. When the goal is completed, the currentCount field is incremented, the score field is incremented by the points value, and the IsCompleted field is set to true. If the currentCount field is equal to the targetCount field, then a bonus of 500 points is awarded.
        {
            if (!_IsCompleted)
            {
                currentCount++;
                _Score += points;

                if (currentCount == targetCount)
                {
                    _IsCompleted = true;
                    _Score += 500; // Bonus points for completing all checklist items
                }
            }
        }

        public string GetProgressStatus() // method returns a string that represents the progress status of the goal
        {
            return $"Completed {currentCount}/{targetCount} times";
        }
    }
}
