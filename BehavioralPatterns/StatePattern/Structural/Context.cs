namespace StatePattern.Structural;

public class Context
{
	public IState State;

	public Context(IState state)
	{
		State = state;
	}

	public void Request()
	{
		State.Handle(this);
	}
}