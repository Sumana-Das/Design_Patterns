using System;

namespace ObserverDesignPattern
{
    class Subscriber : ISubscriber
    {
        private string userName { get; set; }

        public Subscriber(string sub)
        {
            userName = sub;
        }
        public void Notify(string isAvailable)
        {
            Console.WriteLine("Hello " + userName + ", product is now " + isAvailable);
        }
    }
}
