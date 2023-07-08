using System;
using System.Collections.Generic;

namespace Encapsulation
{
    public class Address //  This class represents a customer's address with properties like street address, city, state, and country.
    {
        private string streetAddress;
        private string city;
        private string state;
        private string country;

        public Address(string streetAddress, string city, string state, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public bool IsInUSA() // This method  check if the address is in the USA
        {
            return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public string GetFullAddress() // get the full address string.
        {
            return $"{streetAddress}\n{city}, {state}\n{country}";
        }
    }
}