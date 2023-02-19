namespace StatePattern.Structural;

public class ConcreteStateB : IState
{
	public void Handle(Context context)
	{
		context.State = new ConcreteStateA();
	}
}