namespace FoodDelivery
{
// Class for order placement activity
    public class PlaceOrderActivity : DeliveryActivity
    {
        private string restaurant;
        private string dish;
        private decimal totalAmount;

        public PlaceOrderActivity(string restaurant, string dish, decimal totalAmount) : base("Place Order Activity")
        {
            this.restaurant = restaurant;
            this.dish = dish;
            this.totalAmount = totalAmount;
        }

        protected override void Prepare()
        {
            Console.WriteLine("Finding the best restaurant for you...");
            Thread.Sleep(2000);
            Console.WriteLine($"Restaurant: {restaurant}");
            Console.WriteLine($"Dish: {dish}");
            Console.WriteLine($"Total Amount: ${totalAmount}");
            Console.WriteLine();
        }

        protected override void DoActivity()
        {
            Console.WriteLine("Placing your order...");
            Thread.Sleep(3000);
            Console.WriteLine("Order placed successfully!");
            Console.WriteLine();
        }
    }
}   