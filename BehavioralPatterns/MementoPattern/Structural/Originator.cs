namespace MementoPattern.Structural;

public class Originator
{
	private string _state;

	public void SetState(string state)
	{
		_state = state;

		Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()?.Name}, Set state = {_state}");
	}

	public void RestoreMemento(Memento memento)
	{
		_state = memento.GetState();

		Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()?.Name}, Restore state = {_state}");
	}

	public Memento CreateMemento()
	{
		Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod()?.Name}, Current state = {_state}");

		return new Memento(_state);
	}
}