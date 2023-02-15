namespace ObserverPattern.Structural;

public interface IObserver<T>
{
	void Update(T updated);
}