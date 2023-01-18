// See https://aka.ms/new-console-template for more information
using SequentialFluentBuilder.Example;
using SequentialFluentBuilder.Structural;

Console.WriteLine("Sequential Fluent Interface");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
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

static void PrintProductParts(Product product)
{
	product.GetParts().ForEach(p => Console.WriteLine(p));
}

static void ExampleImplementation()
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

static void PrintVehicleParts(Vehicle vehicle)
{
	Console.WriteLine(vehicle.Type);
	Console.WriteLine(vehicle.Brand);
	foreach (var kvp in vehicle.GetParts())
	{
		Console.WriteLine("{0} = {1}", kvp.Key, kvp.Value);
	}
}