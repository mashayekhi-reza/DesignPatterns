// See https://aka.ms/new-console-template for more information
using BuilderPattern.Structural;

Console.WriteLine("Hello, World!");

StructuralImplementation();

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