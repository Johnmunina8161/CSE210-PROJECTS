namespace FoodDelivery
{
// Class for order tracking activity
    public class TrackOrderActivity : DeliveryActivity
    {
        private string orderId;

        public TrackOrderActivity(string orderId) : base("Track Order Activity")
        {
            this.orderId = orderId;
        }

        protected override void Prepare()
        {
            Console.WriteLine("Retrieving order details...");
            Thread.Sleep(2000);
            Console.WriteLine($"Order ID: {orderId}");
            Console.WriteLine();
        }

        protected override void DoActivity()
        {
            Console.WriteLine("Tracking order status...");
            Thread.Sleep(3000);
            Console.WriteLine($"Order {orderId} is out for delivery!");
            Console.WriteLine();
        }
    }
}