// See https://aka.ms/new-console-template for more information
using DecoratorPattern.Example;
using DecoratorPattern.Structural;

Console.WriteLine("Decorator Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nDecorator Pattern Structural Implementation\n");

	var component = new Component();

	var concreteDecorator1 = new ConcreteDecoratorA(component);
	var concreteDecorator2 = new ConcreteDecoratorB(concreteDecorator1);

	Console.WriteLine($"{component.Operation()}");
	Console.WriteLine($"{concreteDecorator1.Operation()}");
	Console.WriteLine($"{concreteDecorator2.Operation()}");
	Console.WriteLine($"{concreteDecorator2.AddedBehavior()}");
}

static void ExampleImplementation()
{
	Console.WriteLine("\nDecorator Pattern Example Implementation\n");

	var economyCar = new EconomyCar();
	var economyCarWithCustomizedColor = new CustomizedColor(economyCar);
	var economyCarWithCustomizedWheels = new CustomizedWheels(economyCar);
	var economyCarWithCustomizedColorsAndWheels = new CustomizedWheels(economyCarWithCustomizedColor);

	PrintCar(nameof(economyCar), economyCar);
	PrintCar(nameof(economyCarWithCustomizedColor), economyCarWithCustomizedColor);
	PrintCar(nameof(economyCarWithCustomizedWheels), economyCarWithCustomizedWheels);
	PrintCar(nameof(economyCarWithCustomizedColorsAndWheels), economyCarWithCustomizedColorsAndWheels);

	var luxuryCar = new LuxuryCar();
	var luxuryCarWithCustomizedColor = new CustomizedColor(luxuryCar);
	var luxuryCarWithCustomizedWheels = new CustomizedWheels(luxuryCar);
	var luxuryCarWithCustomizedColorsAndWheels = new CustomizedWheels(luxuryCarWithCustomizedColor);

	PrintCar(nameof(luxuryCar), luxuryCar);
	PrintCar(nameof(luxuryCarWithCustomizedColor), luxuryCarWithCustomizedColor);
	PrintCar(nameof(luxuryCarWithCustomizedWheels), luxuryCarWithCustomizedWheels);
	PrintCar(nameof(luxuryCarWithCustomizedColorsAndWheels), luxuryCarWithCustomizedColorsAndWheels);
}

static void PrintCar(string carName, ICar car)
{
	Console.WriteLine($"{carName}, Description: {car.GetDescription()}, Cost: {car.GetCost()}");
}