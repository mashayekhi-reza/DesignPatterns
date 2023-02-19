namespace IteratorPattern.Structural;

public class ConcreteIterator : IIterator
{
	private readonly ConcreteAggregate _aggregate;
	private int _index = 0;

	public ConcreteIterator(ConcreteAggregate aggregate)
	{
		_aggregate = aggregate;
	}

	public object CurrentItem()
	{
		return _aggregate[_index];
	}

	public object First()
	{
		return _aggregate[0];
	}

	public bool IsDone()
	{
		return _index >= _aggregate.Count;
	}

	public object? Next()
	{
		if(++_index < _aggregate.Count)
		{
			return _aggregate[_index];
		}
		return null;
	}
}