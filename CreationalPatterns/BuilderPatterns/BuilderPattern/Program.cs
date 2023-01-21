// See https://aka.ms/new-console-template for more information
using BuilderPattern.RealWorldExample;
using BuilderPattern.Structural;

Console.WriteLine("Builder Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Director director = new();

	IBuilder concreteBuilderA = new ConcreteBuilderA();
	IBuilder concreteBuilderB = new ConcreteBuilderB();

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
	Shop shop = new();

	IVehicleBuilder benzBuilder = new BenzBuilder();
	IVehicleBuilder bmwBuilder = new BmwBuilder();

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