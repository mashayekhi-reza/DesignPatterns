namespace StatePattern.Structural;

public interface IState
{
	void Handle(Context context);
}