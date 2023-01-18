// See https://aka.ms/new-console-template for more information
using FluentBuilderPattern.Example;
using FluentBuilderPattern.Structural;

Console.WriteLine("Fluent Builder Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	ConcreteBuilderA concreteBuilderA = new();
	ConcreteBuilderB concreteBuilderB = new();

	Product productA = concreteBuilderA
		.CreatePartA()
		.CreatePartB()
		.Build();

	Product productB = concreteBuilderB
		.CreatePartA()
		.CreatePartB()
		.Build();

	Console.WriteLine("Product A Parts:");
	PrintProductParts(productA);

	Console.WriteLine("Product B Parts:");
	PrintProductParts(productB);
}

static void PrintProductParts(Product product)
{
	product.GetParts().ForEach(p => Console.WriteLine(p));
}

static void ExampleImplementation()
{
	BenzBuilder benzBuilder = new();
	BmwBuilder bmwBuilder = new();

	Vehicle benz = benzBuilder
		.SetType()
		.SetBrand()
		.AddEngine()
		.AddBody()
		.Build();

	Vehicle bmw = bmwBuilder
		.SetType()
		.SetBrand()
		.AddEngine()
		.AddBody()
		.Build();

	Console.WriteLine("Benz Specifications:");
	PrintVehicleParts(benz);

	Console.WriteLine("Bmw Specifications:");
	PrintVehicleParts(bmw);
}

static void PrintVehicleParts(Vehicle vehicle)
{
	Console.WriteLine(vehicle.Type);
	Console.WriteLine(vehicle.Brand);
	foreach (var kvp in vehicle.GetParts())
	{
		Console.WriteLine("{0} = {1}", kvp.Key, kvp.Value);
	}
}