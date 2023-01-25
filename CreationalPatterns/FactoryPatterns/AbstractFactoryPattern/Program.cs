// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.Example;
using AbstractFactoryPattern.Example.VehiclePartsFactories;
using AbstractFactoryPattern.Structural.Factories;

Console.WriteLine("Abstract Factory Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("Structural Implementation \n");

	List<IFactory> factories = new List<IFactory>
{
	new ConcreteFactoryOne(),
	new ConcreteFactoryTwo()
};

	foreach (var factory in factories)
	{
		Console.WriteLine($"{factory.GetType().Name}\n" +
			$"\t{factory.CreateProductA().GetType().Name}\n" +
			$"\t{factory.CreateProductB().GetType().Name}");
	}
}

static void ExampleImplementation()
{
	Console.WriteLine("\nExample Implementation \n");
	var vehicleCreator = new VehicleCreator();

	List<IVehiclePartsFactory> vehiclePartsFactories = new()
	{
		new CarPartsFactory(),
		new BoatPartsFactory()
	};

	foreach(var factory in vehiclePartsFactories)
	{
		vehicleCreator.SetVehiclePartsFactory(factory);
		Console.WriteLine(vehicleCreator.AssembleVehicle());
	}
}