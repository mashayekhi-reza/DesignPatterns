namespace VisitorPattern.SimplifiedStructural;

public class SimplifiedObjectStructure
{
	private readonly List<ISimplifiedElement> _elements;

	public SimplifiedObjectStructure()
	{
		_elements = new();
	}

	public void Attach(ISimplifiedElement element)
	{
		_elements.Add(element);
	}

	public void Accept(ISimplifiedVisitor visitor)
	{
		foreach (var element in _elements)
		{
			element.Accept(visitor);
		}
	}
}