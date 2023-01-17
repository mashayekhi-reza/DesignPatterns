// See https://aka.ms/new-console-template for more information
using BuilderPattern.RealWorldExample;
using BuilderPattern.Structural;

Console.WriteLine("Hello, World!");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Director director = new();

	ConcreteBuilderA concreteBuilderA = new();
	ConcreteBuilderB concreteBuilderB = new();

	director.Contruct(concreteBuilderA);
	Product productA = concreteBuilderA.GetProduct();

	director.Contruct(concreteBuilderB);
	Product productB = concreteBuilderB.GetProduct();

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

	Shop shop = new();

	shop.Construct(benzBuilder);
	Vehicle benz = benzBuilder.GetVehicle();

	shop.Construct(bmwBuilder);
	Vehicle bmw = bmwBuilder.GetVehicle();

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