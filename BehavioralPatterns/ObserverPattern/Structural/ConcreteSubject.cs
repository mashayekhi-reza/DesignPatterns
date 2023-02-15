namespace Observer_Pattern.Structural;

public class ConcreteSubject : Subject<string> 
{
	public string Name { get; private set; }

	public ConcreteSubject(string name)
	{
		Name = name;
	}

	public void ChangeName(string name)
	{
		Name = name;
		Notify(name);
	}
}