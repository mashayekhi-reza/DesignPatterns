namespace StatePattern.Structural;

public class ConcreteStateA : IState
{
	public void Handle(Context context)
	{
		context.State = new ConcreteStateB();
	}
}