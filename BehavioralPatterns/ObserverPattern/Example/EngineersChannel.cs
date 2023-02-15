namespace ObserverPattern.Example;

public class EngineersChannel : Structural.IObserver<CompanyEvent>
{
	public void Update(CompanyEvent companyEvent)
	{
		Console.WriteLine($"{GetType().Name}: The new event details:\nTitle: {companyEvent.Title}\nNumber of Participants: {companyEvent.NumberOfParticipant}");
	}
}