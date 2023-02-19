namespace VisitorPattern.SimplifiedStructural;

public class ConcreteSimplifiedElementB : ISimplifiedElement
{
	public void Accept(ISimplifiedVisitor visitor)
	{
		visitor.Visit(this);
	}
}