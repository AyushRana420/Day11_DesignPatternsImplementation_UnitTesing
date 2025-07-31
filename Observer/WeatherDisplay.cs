namespace DesignPatternsImplementation.Observer
{
    // WeatherDisplay subscribes to weather updates and displays the latest data.
    public class WeatherDisplay : IObserver
    {
        private string name;
        public WeatherDisplay(string name)
        {
            this.name = name;
        }

        public void Update(float temperature, float humidity)
        {
            Console.WriteLine($"{name} - Temperature: {temperature}°C, Humidity: {humidity}%");
        }
    }
}
