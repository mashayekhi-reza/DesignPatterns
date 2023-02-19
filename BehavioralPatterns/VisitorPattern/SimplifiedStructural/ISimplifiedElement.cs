namespace VisitorPattern.SimplifiedStructural;

public interface ISimplifiedElement
{
	void Accept(ISimplifiedVisitor visitor);
}