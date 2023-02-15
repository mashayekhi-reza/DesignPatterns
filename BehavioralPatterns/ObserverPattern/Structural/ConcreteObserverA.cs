namespace ObserverPattern.Structural;

public class ConcreteObserverA : IObserver<string>
{
	private string _name;

	public ConcreteObserverA(string name)
	{
		_name = name;
	}

	public void Update(string name)
	{
		_name = name;
		Console.WriteLine($"{GetType().Name} notified about the name change and the new name is {_name}");
	}
}