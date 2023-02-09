using StrategyPattern.Structural;

Console.WriteLine("Strategy Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nStrategy Pattern Structural Implementation\n");

	var concreteStrategyA = new ConcreteStrategyA();
	var contextA = new Context(concreteStrategyA);
	contextA.ContextInterface();

	var concreteStrategyB = new ConcreteStrategyB();
	var contextB = new Context(concreteStrategyB);
	contextB.ContextInterface();
}

