namespace DesignPatternsImplementation.Observer
{
    //Observer interface defines the Update method to be implemented by all observers.
    public interface IObserver
    {
        void Update(float temperature, float humidity);
    }
}
