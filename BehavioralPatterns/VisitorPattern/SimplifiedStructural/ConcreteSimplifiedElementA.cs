namespace VisitorPattern.SimplifiedStructural;

public class ConcreteSimplifiedElementA : ISimplifiedElement
{
	public void Accept(ISimplifiedVisitor visitor)
	{
		visitor.Visit(this);
	}
}