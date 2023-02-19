namespace VisitorPattern.Structural;

public class ConcreteVisitorB : IVisitor
{
	public void VisitConcreteElementA(ConcreteElementA concreteElementA)
	{
		Console.WriteLine($"{concreteElementA.GetType().Name} visited by {GetType().Name} via {System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
	}

	public void VisitConcreteElementB(ConcreteElementB concreteElementB)
	{
		Console.WriteLine($"{concreteElementB.GetType().Name} visited by {GetType().Name} via {System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
	}
}