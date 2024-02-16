public class OutdoorGathering : Event
{
    private string WeatherForecast { get; set; }

    // Constructor
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, string address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    // Method to generate full details message
    public string GenerateFullDetailsMessage()
    {
        return $"{GenerateStandardDetailsMessage()}\nWeather Forecast: {WeatherForecast}";
    }
}