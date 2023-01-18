// See https://aka.ms/new-console-template for more information
using FluentBuilderPattern.Structural;

Console.WriteLine("Fluent Builder Pattern");

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

static void PrintProductParts(Product product)
{
	product.GetParts().ForEach(p => Console.WriteLine(p));
}