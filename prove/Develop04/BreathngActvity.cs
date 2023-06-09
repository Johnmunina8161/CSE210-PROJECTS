public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int breatheInSeconds = duration / 2;
        int breatheOutSeconds = duration - breatheInSeconds;

        for (int i = 0; i < breatheInSeconds; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(1);
            Console.WriteLine("Breathe out...");
            Pause(1);
        }
    }
}