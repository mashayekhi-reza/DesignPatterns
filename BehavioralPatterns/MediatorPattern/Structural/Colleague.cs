namespace MediatorPattern.Structural;

public abstract class Colleague
{
	protected IMediator Mediator;

	public Colleague(IMediator mediator)
	{
		Mediator = mediator;
	}

	public abstract void Send(string message);

	public abstract void Receive(string message);
}