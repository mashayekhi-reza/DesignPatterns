namespace MediatorPattern.Structural;

public class ConcreteMediator : IMediator
{
	private Colleague _colleagueA;

	private Colleague _colleagueB;

	public void SetColleagueA(Colleague colleague) => _colleagueA = colleague;

	public void SetColleagueB(Colleague colleague) => _colleagueB = colleague;

	public void Send(string message, Colleague colleague)
	{
		if (colleague == _colleagueA)
		{
			_colleagueB.Receive(message);
		}
		else
		{
			_colleagueA.Receive(message);
		}
	}
}