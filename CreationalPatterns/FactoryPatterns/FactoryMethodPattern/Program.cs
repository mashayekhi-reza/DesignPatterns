// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern.Example;
using FactoryMethodPattern.Structural;

Console.WriteLine("Factory Method Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("Factory Method Pattern (Structural Implementation)\n");

	var factories = new List<IProductFactory>
	{
		new ProductAFactory(),
		new ProductBFactory()
	};

	foreach (var factory in factories)
	{
		var p = factory.CreateProduct();
		Console.WriteLine($"Type: {p.GetType().Name}, Action: {p.Act()}");
	}
}

static void ExampleImplementation()
{
	Console.WriteLine("\nFactory Method Pattern (Example Implementation)\n");

	var documents = new List<IDocument>
	{
		new Resume(),
		new Report()
	};

	foreach (var document in documents)
	{
		document.CreatePages();
		Console.WriteLine("\n" + document.GetType().Name + "--");
		foreach (var page in document.Pages)
		{
			Console.WriteLine(" " + page.GetType().Name);
		}
	}
}