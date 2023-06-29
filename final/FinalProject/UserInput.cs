namespace FoodDelivery
{
  // Class for handling user input
    public class UserInput
    {
        public static int GetChoice()
        {
            Console.Write("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string GetRestaurant()
        {
            Console.Write("Enter the restaurant name: ");
            return Console.ReadLine();
        }

        public static string GetDish()
        {
            Console.Write("Enter the dish name: ");
            return Console.ReadLine();
        }

        public static decimal GetTotalAmount()
        {
            Console.Write("Enter the total amount: ");
            return Convert.ToDecimal(Console.ReadLine());
        }

        public static string GetOrderId()
        {
            Console.Write("Enter the order ID: ");
            return Console.ReadLine();
        }
    }
}   
