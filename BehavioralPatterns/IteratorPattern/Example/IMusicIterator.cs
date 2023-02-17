namespace IteratorPattern.Example;

public interface IMusicIterator
{
	Music CurrentItem();
	Music First();
	bool IsDone();
	Music? Next();
}