namespace ChainOfResponsibilityPattern.Structural;

public class ConcreteHandlerB : IHandler<int>
{
	private IHandler<int>? _successor;

	public void Handle(int request)
	{
		if (request > 9 && request < 100)
		{
			Console.WriteLine($"It is handled in {nameof(ConcreteHandlerB)}");
		}
		else
		{
			_successor?.Handle(request);
		}
	}
	public IHandler<int> SetSuccessor(IHandler<int> successor)
	{
		_successor = successor;
		return successor;
	}
}