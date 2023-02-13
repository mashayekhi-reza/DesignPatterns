namespace MediatorPattern.Structural;

public class ConcreteColleagueA : Colleague
{
	public ConcreteColleagueA(IMediator mediator) : base(mediator)
	{
	}

	public override void Receive(string message)
	{
		Console.WriteLine($"{nameof(ConcreteColleagueA)} receives {message}");
	}

	public override void Send(string message)
	{
		Mediator.Send(message, this);
	}
}