using System;
namespace Inheritance
{
    // Derived WeddingEvent class
    class WeddingEvent : Event
    {
        private string brideName;
        private string groomName;

        public WeddingEvent(string name, DateTime date, Address location, string brideName, string groomName)
            : base(name, date, location)
        {
            this.brideName = brideName;
            this.groomName = groomName;
        }

        public override string GenerateMarketingMessage()
        {
            return $"{base.GenerateMarketingMessage()} Celebrate the union of {brideName} and {groomName}!";
        }
    }
}