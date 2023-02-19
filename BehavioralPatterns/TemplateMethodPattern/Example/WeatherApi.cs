namespace TemplateMethodPattern.Example;

public abstract class WeatherApi
{
	public void GetWeatherInfo(string city)
	{
		FindServer();
		Authenticate();
		FetchWeatherForecast(city);
	}

	protected abstract void FindServer(); 
	protected abstract void Authenticate(); 
	protected abstract void FetchWeatherForecast(string city);
}