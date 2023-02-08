using TemplateMethodPattern.Example;
using TemplateMethodPattern.Structural;

Console.WriteLine("Template Method Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nTemplate Method Pattern Structural Implementation\n");

	AbstractClass class1 = new ConcreteClassA();
	AbstractClass class2 = new ConcreteClassB();

	class1.TemplateMethod();
	class2.TemplateMethod();
}

static void ExampleImplementation()
{
	Console.WriteLine("\nTemplate Method Pattern Example Implementation\n");

	WeatherApi meteostat = new Meteostat();
	WeatherApi weatherEmbed = new WeatherEmbed();

	meteostat.GetWeatherInfo("City One");
	weatherEmbed.GetWeatherInfo("City Two");
}