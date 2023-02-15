namespace Observer_Pattern.Structural;

public class ConcreteObserverB : IObserver<string>
{
	private string _name;

	public ConcreteObserverB(string name)
	{
		_name = name;
	}

	public void Update(string name)
	{
		_name = name;
		Console.WriteLine($"{GetType().Name} notified about the name change and the new name is {_name}");
	}
}