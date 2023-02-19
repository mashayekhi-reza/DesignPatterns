namespace IteratorPattern.Structural;

public interface IAggregate
{
	IIterator CreateIterator();
}