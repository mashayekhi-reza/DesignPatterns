namespace VisitorPattern.Structural;

public class ObjectStructure
{
	private readonly List<IElement> _elements;

	public ObjectStructure()
	{
		_elements = new();
	}

	public void Attach(IElement element)
	{
		_elements.Add(element);
	}

	public void Accept(IVisitor visitor)
	{
		foreach(var element in _elements)
		{
			element.Accept(visitor);
		}
	}
}