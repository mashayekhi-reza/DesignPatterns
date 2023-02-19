namespace VisitorPattern.SimplifiedStructural;

public class ConcreteSimplifiedVisitorA : ISimplifiedVisitor
{
	public void Visit(ISimplifiedElement element)
	{
		if (element is ConcreteSimplifiedElementA)
		{
			Console.Write($"From visitor part for {nameof(ConcreteSimplifiedElementA)}:");
		}
		else if (element is ConcreteSimplifiedElementB)
		{
			Console.Write($"From visitor part for {nameof(ConcreteSimplifiedElementB)}:");
		}

		Console.WriteLine($"{element.GetType().Name} visited by {GetType().Name} via {System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
	}
}