namespace ChainOfResponsibilityPattern.Structural;

public class ConcreteHandlerA : IHandler<int>
{
	private IHandler<int>? _successor;

	public void Handle(int request)
	{
		if (request < 10)
		{
			Console.WriteLine($"It is handled in {nameof(ConcreteHandlerA)}");
		}
		else
		{
			_successor?.Handle(request);
		}
	}

	public void SetSuccessor(IHandler<int> successor)
	{
		_successor = successor;
	}
}