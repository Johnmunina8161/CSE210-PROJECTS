namespace FoodDelivery
{

     // Class for order cancellation activity
    public class CancelOrderActivity : DeliveryActivity
    {
         private string orderId;

        public CancelOrderActivity(string orderId) : base("Cancel Order Activity")
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
            Console.WriteLine("Canceling your order...");
            Thread.Sleep(3000);
            Console.WriteLine($"Order {orderId} has been canceled successfully!");
            Console.WriteLine();
        }
    }
}
    