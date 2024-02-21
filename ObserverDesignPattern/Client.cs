using System;

namespace ObserverDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Publisher mobile = new Publisher("Redmi", "Out of stock");

            Subscriber sub1 = new Subscriber("Steve");
            Subscriber sub2 = new Subscriber("John");
            Subscriber sub3 = new Subscriber("Ian");

            mobile.Subscribe(sub1);
            mobile.Subscribe(sub2);
            mobile.Subscribe(sub3);

            Console.WriteLine("Red MI Mobile current state : " + mobile.GetAvailability());

            mobile.Unsubscribe(sub1);

            mobile.SetAvailability("Available");
        }
    }
}
