using System;
namespace Inheritance
{
    // Derived ConferenceEvent class
    class ConferenceEvent : Event
    {
        private string organizer;
        private string topic;

        public ConferenceEvent(string name, DateTime date, Address location, string organizer, string topic)
            : base(name, date, location)
        {
            this.organizer = organizer;
            this.topic = topic;
        }

        public override string GenerateMarketingMessage()
        {
            return $"{base.GenerateMarketingMessage()} Learn from industry experts on {topic}!";
        }
    }
}