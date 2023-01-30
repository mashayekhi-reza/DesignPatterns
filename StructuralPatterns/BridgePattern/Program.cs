// See https://aka.ms/new-console-template for more information
using BridgePattern.Structural;

Console.WriteLine("Bridge Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nBridge Pattern Implementation\n");

	IImplementor concreteImplementorA = new ConcreteImplementorA();

	Abstraction refinedAbstractionA = new RefinedAbstractionA(concreteImplementorA);

	Console.WriteLine(refinedAbstractionA.Operation());

	IImplementor concreteImplementorB = new ConcreteImplementorB();

	Abstraction refinedAbstractionB = new RefinedAbstractionB(concreteImplementorB);

	Console.WriteLine(refinedAbstractionB.Operation());
}