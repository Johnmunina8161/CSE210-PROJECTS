namespace FoodDelivery
{
  // Main program class
    public class FoodDeliveryProgram
    {
        static void Main(string[] args)
        {
            WelcomeMessage.Display();
            Console.WriteLine();

            MenuOptions.Display();
            int choice = UserInput.GetChoice();
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    string restaurant = UserInput.GetRestaurant();
                    string dish = UserInput.GetDish();
                    decimal totalAmount = UserInput.GetTotalAmount();

                    DeliveryActivity placeOrderActivity = new PlaceOrderActivity(restaurant, dish, totalAmount);
                    placeOrderActivity.PerformActivity();
                    break;

                case 2:
                    string trackOrderId = UserInput.GetOrderId();

                    DeliveryActivity trackOrderActivity = new TrackOrderActivity(trackOrderId);
                    trackOrderActivity.PerformActivity();
                    break;

                case 3:
                    string cancelOrderId = UserInput.GetOrderId();

                    DeliveryActivity cancelOrderActivity = new CancelOrderActivity(cancelOrderId);
                    cancelOrderActivity.PerformActivity();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Exiting program.");
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
