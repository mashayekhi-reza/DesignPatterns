namespace VisitorPattern.Structural;

public class ConcreteElementA : IElement
{
	public void Accept(IVisitor visitor)
	{
		visitor.VisitConcreteElementA(this);
	}
}