// Base class for a food item
public abstract class FoodItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public abstract void Display();
}

// Derived class for a burger
public class Burger : FoodItem
{
    public string Size { get; set; }

    public override void Display()
    {
        Console.WriteLine($"Burger: {Name} ({Size}), Price: {Price}");
    }
}

// Derived class for a drink
public class Drink : FoodItem
{
    public string Size { get; set; }

    public override void Display()
    {
        Console.WriteLine($"Drink: {Name} ({Size}), Price: {Price}");
    }
}

// Base class for the order
public abstract class Order
{
    private List<FoodItem> items;

    public Order()
    {
        items = new List<FoodItem>();
    }

    public void AddItem(FoodItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(FoodItem item)
    {
        items.Remove(item);
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Order Details:");
        foreach (var item in items)
        {
            item.Display();
        }
    }
}

// Derived class for a dine-in order
public class DineInOrder : Order
{
    public string TableNumber { get; set; }

    public void ReserveTable(string tableNumber)
    {
        TableNumber = tableNumber;
        Console.WriteLine($"Table {TableNumber} reserved for dine-in order.");
    }
}

// Derived class for a drive-thru order
public class DriveThruOrder : Order
{
    public string CarLicensePlate { get; set; }

    public void TakeCarDetails(string licensePlate)
    {
        CarLicensePlate = licensePlate;
        Console.WriteLine($"Car details ({CarLicensePlate}) taken for drive-thru order.");
    }
}

// Class to manage the program and interact with users
public class McDonaldsProgram
{
    private List<Order> orders;

    public McDonaldsProgram()
    {
        orders = new List<Order>();
    }

    public void StartProgram()
    {
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("Welcome to McDonald's!");
            Console.WriteLine("1. Place Dine-in Order");
            Console.WriteLine("2. Place Drive-thru Order");
            Console.WriteLine("3. Display Orders");
            Console.WriteLine("4. Quit Program");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PlaceDineInOrder();
                    break;
                case "2":
                    PlaceDriveThruOrder();
                    break;
                case "3":
                    DisplayOrders();
                    break;
                case "4":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void PlaceDineInOrder()
    {
        DineInOrder order = new DineInOrder();
        Console.Write("Enter the table number: ");
        string tableNumber = Console.ReadLine();
        order.ReserveTable(tableNumber);

        // Add food items to the order
        Burger burger = new Burger
        {
            Name = "Cheeseburger",
            Price = 2.99m,
            Size = "Regular"
        };
        order.AddItem(burger);

        Drink drink = new Drink
        {
            Name = "Coca-Cola",
            Price = 1.49m,
            Size = "Medium"
        };
        order.AddItem(drink);

        orders.Add(order);
        Console.WriteLine("Dine-in order placed successfully.");
    }

    private void PlaceDriveThruOrder()
    {
        DriveThruOrder order = new DriveThruOrder();
        Console.Write("Enter the car license plate: ");
        string licensePlate = Console.ReadLine();
        order.TakeCarDetails(licensePlate);

        // Add food items to the order
        Burger burger = new Burger
        {
            Name = "Big Mac",
            Price = 4.99m,
            Size = "Large"
        };
        order.AddItem(burger);

        Drink drink = new Drink
        {
            Name = "Sprite",
            Price = 1.49m,
            Size = "Small"
        };
        order.AddItem(drink);

        orders.Add(order);
        Console.WriteLine("Drive-thru order placed successfully.");
    }

    private void DisplayOrders()
    {
        Console.WriteLine("All Orders:");
        foreach (var order in orders)
        {
            order.DisplayOrder();
        }
    }
}


