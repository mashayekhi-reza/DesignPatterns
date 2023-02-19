using StatePattern.Example;
using StatePattern.Structural;

Console.WriteLine("State Pattern");

StructuralImplementation();

ExampleImplementation();

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

static void ExampleImplementation()
{
	Console.WriteLine("\nState Pattern Example Implementation\n");

	Console.WriteLine("Robot A");
	var robotA = new Robot();
	robotA.Act(ActionDifficultyLevel.Normal);
	robotA.Act(ActionDifficultyLevel.Difficult);
	robotA.Act(ActionDifficultyLevel.Normal);
	robotA.Act(ActionDifficultyLevel.Normal);


	Console.WriteLine("\nRobot B");
	var robotB = new Robot();
	robotB.Act(ActionDifficultyLevel.Difficult);
	robotB.Act(ActionDifficultyLevel.Normal);
}