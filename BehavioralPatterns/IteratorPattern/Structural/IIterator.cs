namespace IteratorPattern.Structural;

public interface IIterator
{
    object CurrentItem();
    object First();
    bool IsDone();
    object? Next();
}