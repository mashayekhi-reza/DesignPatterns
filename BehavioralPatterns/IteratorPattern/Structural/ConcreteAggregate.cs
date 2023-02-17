namespace IteratorPattern.Structural;

public class ConcreteAggregate : List<object>, IAggregate
{
	public IIterator CreateIterator()
	{
		return new ConcreteIterator(this);
	}
}