// See https://aka.ms/new-console-template for more information
using DecoratorPattern.Structural;

Console.WriteLine("Decorator Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nDecorator Pattern Structural Implementation\n");

	IComponent component = new Component();

	Decorator concreteDecorator1 = new ConcreteDecoratorA(component);
	Decorator concreteDecorator2 = new ConcreteDecoratorB(concreteDecorator1);

	ConcreteDecoratorB concreteDecorator3 = new(concreteDecorator2);

	Console.WriteLine($"{component.Operation()}");
	Console.WriteLine($"{concreteDecorator1.Operation()}");
	Console.WriteLine($"{concreteDecorator2.Operation()}");
	Console.WriteLine($"{concreteDecorator3.AddedBehavior()}");
}
