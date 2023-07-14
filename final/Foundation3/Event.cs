using System;
namespace Inheritance
{ class Event
    {
        private string name;
        private DateTime date;
        private Address location;

        public Event(string name, DateTime date, Address location)
        {
            this.name = name;
            this.date = date;
            this.location = location;
        }

        public string GetName()
        {
            return name;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public string GetLocation()
        {
            return location.ToString();
        }

        public virtual string GenerateMarketingMessage()
        {
            return $"Join us for {name} on {date.ToShortDateString()} at {location}!";
        }
    }
}