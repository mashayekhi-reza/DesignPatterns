namespace ChainOfResponsibilityPattern.Structural;

public class ConcreteHandlerC : IHandler<int>
{
	private IHandler<int>? _successor;

	public void Handle(int request)
	{
		Console.WriteLine($"It is handled in {nameof(ConcreteHandlerC)}");
	}

	public IHandler<int> SetSuccessor(IHandler<int> successor)
	{
		_successor = successor;
		return successor;
	}
}