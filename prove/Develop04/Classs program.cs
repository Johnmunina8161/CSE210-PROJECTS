public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindful Program!");

        while (true)
        {
        
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice you want to perform: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
                break;

            Activity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                 case 4:
                    // Quite
                    Console.WriteLine("\nThank you for using the Program , Good bye!\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

           // Console.WriteLine();
           // activity.Start();
        }

       // Console.WriteLine("Goodbye!");
    }
}
