namespace VisitorPattern.Structural;

public interface IElement
{
	void Accept(IVisitor visitor);
}