// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.Structural.Factories;

Console.WriteLine("Abstract Factory Pattern");

StructuralImplementation();

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