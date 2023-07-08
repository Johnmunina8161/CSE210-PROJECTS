using System;
using System.Collections.Generic;

namespace Encapsulation
{
    public class Product // The Product class represents a product with properties like name, product ID, price, and quantity
    {
        private string name;
        private int productId;
        private decimal price;
        private int quantity;

        public Product(string name, int productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public decimal GetTotalPrice() // This method calculate the total price of the product based on its price and quantity.
        {
            return price * quantity;
        }

        public string GetName()
        {
            return name;
        }

        public int GetProductId()
        {
            return productId;
        }
    }

}