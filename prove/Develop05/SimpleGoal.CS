namespace gamification 
{
    // Simple goal class
    public class SimpleGoal : Goal
    {
        private int points;

        public SimpleGoal(string description, int points) : base(description)
        {
            this.points = points;
        }

        public override void Complete()
        {
            if (!_IsCompleted)
            {
                _IsCompleted = true;
                _Score += points;
            }
        }
    }
}
