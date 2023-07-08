using System;
using System.Collections.Generic;

namespace Encapsulation
{
     public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            products = new List<Product>();
            this.customer = customer;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.GetTotalPrice();
            }

            if (customer.IsInUSA())
            {
                totalPrice += 5; // USA shipping cost
            }
            else
            {
                totalPrice += 35; // International shipping cost
            }

            return totalPrice;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in products)
            {
                packingLabel += $"Name: {product.GetName()}, ID: {product.GetProductId()}\n";
            }

            return packingLabel;
        }

        public string GetShippingLabel()
        {
            Address address = customer.GetAddress();
            return $"Name: {customer.GetName()}\nAddress:\n{address.GetFullAddress()}";
        }
    }

}