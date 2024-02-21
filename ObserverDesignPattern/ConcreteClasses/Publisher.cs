using System;
using System.Collections.Generic;
using ObserverDesignPattern.Interfaces;

namespace ObserverDesignPattern
{
    class Publisher : IPublisher
    {
        private List<ISubscriber> users = new List<ISubscriber>();
        private string availability { get; set; }
        private string productName { get; set; }
        
        public Publisher(string pName, string isAvailable)
        {
            productName = pName;
            availability = isAvailable;
        }
        public string GetAvailability()
        {
            return availability;
        }
        public void SetAvailability(string isAvailable)
        {
            availability = isAvailable;
            Console.WriteLine("Product availability changed from Out of stock to available");
            NotifySubscribers();
        }
        public void NotifySubscribers()
        {
            Console.WriteLine("Product Name :"
                            + productName + " is Now available. So, notifying all Registered users ");
            foreach (var user in users)
            {
                user.Notify(availability);
            }
        }
        public void Subscribe(ISubscriber user)
        {
            users.Add(user);
        }
        public void Unsubscribe(ISubscriber user)
        {
            users.Remove(user);
        }
    }
}
