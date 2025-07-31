namespace DesignPatternsImplementation.Observer
{
    // WeatherStation is the subject that notifies observers when weather data changes.
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity);
            }
        }
        //Sets the latest weather measurements and notifies all observers.
        public void SetMeasurements(float temperature, float humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            NotifyObservers();
        }
    }
}
