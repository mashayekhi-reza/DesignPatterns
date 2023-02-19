namespace ObserverPattern.Example;

public class CompanyEvent
{
	public string Title { get; private set; }
	public int NumberOfParticipant { get; private set; }

	public CompanyEvent(string title, int numberOfParticipant)
	{
		Title = title;
		NumberOfParticipant = numberOfParticipant;
	}
}