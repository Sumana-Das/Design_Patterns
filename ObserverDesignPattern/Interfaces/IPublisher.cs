
namespace ObserverDesignPattern.Interfaces
{
    interface IPublisher
    {
        void Subscribe(ISubscriber sub);
        void Unsubscribe(ISubscriber sub);
        void NotifySubscribers();
    }
}
