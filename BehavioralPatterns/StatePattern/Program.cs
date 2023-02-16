using StatePattern.Structural;

Console.WriteLine("State Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nState Pattern Structural Implementation\n");

	var context = new Context(new ConcreteStateA());

	for (var i = 0; i < 4; i++)
	{
		Console.WriteLine($"Current State: {context.State.GetType().Name}");

		context.Request();
	}
}