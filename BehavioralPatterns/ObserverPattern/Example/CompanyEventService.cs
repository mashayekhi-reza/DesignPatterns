using ObserverPattern.Structural;

namespace ObserverPattern.Example;

public class CompanyEventService : Subject<CompanyEvent>
{
	public void AnnounceEvent(string title, int numberOfParticipant)
	{
		Console.WriteLine($"{GetType().Name} is announcing new event:\n");
		Notify(new CompanyEvent(title, numberOfParticipant));
	}
}