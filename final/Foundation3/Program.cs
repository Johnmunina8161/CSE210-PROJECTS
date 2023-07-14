using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Address weddingLocation = new Address("123 Main St", "New York", "NY", "USA");
            WeddingEvent weddingEvent = new WeddingEvent("John and Jane's Wedding", new DateTime(2023, 12, 31), weddingLocation, "Jane", "John");

            Address conferenceLocation = new Address("456 Market St", "San Francisco", "CA", "USA");
            ConferenceEvent conferenceEvent = new ConferenceEvent("Tech Conference", new DateTime(2023, 10, 15), conferenceLocation, "Tech Corp", "Artificial Intelligence");

            Console.WriteLine(weddingEvent.GenerateMarketingMessage());
            Console.WriteLine(conferenceEvent.GenerateMarketingMessage());
        }
    }
}