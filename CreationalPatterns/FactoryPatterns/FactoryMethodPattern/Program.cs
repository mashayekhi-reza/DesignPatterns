// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern.Structural;

Console.WriteLine("Factory Method Pattern");

var factories = new List<IProductFactory>();

factories.Add(new ProductAFactory());
factories.Add(new ProductBFactory());

foreach(var factory in factories)
{
	var p = factory.CreateProduct();
	Console.WriteLine($"Type: {p}, Action: {p.Act()}");
}

Console.ReadKey();

