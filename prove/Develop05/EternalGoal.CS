namespace gamification 
{
    // Eternal goal class
    public class EternalGoal : Goal // This means that it inherits all of the functionality of the Goal class, such as a description and a score.
    {
        private int points; // This field stores the number of points that are awarded each time the goal is completed.

        public EternalGoal(string description, int points) : base(description) // constructor initializes the goal with the given description and points.
        {
            this.points = points;
        }

        public override void Complete() // This method is used to complete the goal. When the goal is completed, the score field is incremented by the points value.
        {
            _Score += points;
        }
    }
}
