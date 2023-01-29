// See https://aka.ms/new-console-template for more information
using FluentBuilderPattern.Example;
using FluentBuilderPattern.Structural;

Console.WriteLine("Fluent Builder Pattern");
Console.WriteLine("\nFluent Builder Pattern without Director\n");

StructuralImplementationWithoutDirector();

ExampleImplementationWithoutDirector();

Console.WriteLine("\nFluent Builder Pattern with Director\n");

StructuralImplementationWithDirector();

ExampleImplementationWithDirector();

Console.ReadKey();

static void StructuralImplementationWithoutDirector()
{
	IBuilder concreteBuilderA = new ConcreteBuilderA();
	IBuilder concreteBuilderB = new ConcreteBuilderB();

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

static void StructuralImplementationWithDirector()
{
	Director director = new();

	IBuilder concreteBuilderA = new ConcreteBuilderA();
	IBuilder concreteBuilderB = new ConcreteBuilderB();

	director.Contruct(concreteBuilderA);
	Product productA = concreteBuilderA.Build();

	director.Contruct(concreteBuilderB);
	Product productB = concreteBuilderB.Build();

	Console.WriteLine("Product A Parts:");
	PrintProductParts(productA);

	Console.WriteLine("Product B Parts:");
	PrintProductParts(productB);
}

static void PrintProductParts(Product product)
{
	product.GetParts().ForEach(p => Console.WriteLine(p));
}

static void ExampleImplementationWithoutDirector()
{
	IVehicleBuilder benzBuilder = new BenzBuilder();
	IVehicleBuilder bmwBuilder = new BmwBuilder();

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

static void ExampleImplementationWithDirector()
{
	Shop shop = new();

	IVehicleBuilder benzBuilder = new BenzBuilder();
	IVehicleBuilder bmwBuilder = new BmwBuilder();

	shop.Construct(benzBuilder);
	Vehicle benz = benzBuilder.Build();

	shop.Construct(bmwBuilder);
	Vehicle bmw = bmwBuilder.Build();

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