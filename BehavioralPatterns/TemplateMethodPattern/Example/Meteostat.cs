namespace TemplateMethodPattern.Example;

public class Meteostat : WeatherApi
{
	protected override void Authenticate() => Console.WriteLine($"Authenticate to {GetType().Name}...");

	protected override void FetchWeatherForecast(string city) => Console.WriteLine($"Fetching weather info from {GetType().Name} for {city}...");

	protected override void FindServer() => Console.WriteLine($"Finding one of the {GetType().Name} servers...");
}