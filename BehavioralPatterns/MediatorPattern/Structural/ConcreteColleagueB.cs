namespace MediatorPattern.Structural;

public class ConcreteColleagueB : Colleague
{
	public ConcreteColleagueB(IMediator mediator) : base(mediator)
	{
	}

	public override void Receive(string message)
	{
		Console.WriteLine($"{nameof(ConcreteColleagueB)} receives {message}");
	}

	public override void Send(string message)
	{
		Mediator.Send(message, this);
	}
}