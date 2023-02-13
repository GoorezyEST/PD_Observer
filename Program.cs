namespace Observer_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a WeatherData object
            WeatherData weatherData = new WeatherData();

            // Create a CurrentConditionsDisplay object and register it as an observer of the WeatherData object
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            // Change the measurements of the WeatherData object
            weatherData.SetMeasurements(80, 65, 30.4f);

            // The CurrentConditionsDisplay will automatically display the updated values
        }
    }
}