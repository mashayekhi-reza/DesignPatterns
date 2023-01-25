// See https://aka.ms/new-console-template for more information
using ParameterizedFactoryMethod.Example.Factory;
using ParameterizedFactoryMethod.Structural.Factory;

Console.WriteLine("Parameterized Factory Method");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nStructural Implementation\n");

	IFactory factory = new ConcreteFactory();

	Console.WriteLine($"Key is A, the product is: {factory.CreateProduct("A").GetType().Name}");
	Console.WriteLine($"Key is B, the product is: {factory.CreateProduct("B").GetType().Name}");
	Console.WriteLine($"Key is C, which is not available, the product is: {factory.CreateProduct("C").GetType().Name}");
}

static void ExampleImplementation()
{
	Console.WriteLine("\nExample Implementation\n");

	IVehicleFactory factory = new VehicleFactory();

	Console.WriteLine($"Order Car to Drive: {factory.CreateVehicle("Car").Drive()}");
	Console.WriteLine($"Order Boat to Drive: {factory.CreateVehicle("Boat").Drive()}");
	Console.WriteLine($"Order Bicycle to Drive: {factory.CreateVehicle("Bicycle").Drive()}");
}