
namespace DesignPatternsImplementation.Observer
{
    // Subject interface defines methods for registering, removing, and notifying observers.
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
