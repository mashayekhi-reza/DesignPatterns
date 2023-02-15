namespace ObserverPattern.Structural;

public abstract class Subject<T>
{
	private readonly List<IObserver<T>> _observers;

	public Subject()
	{
		_observers = new();
	}

	public void Attach(IObserver<T> observer)
	{
		_observers.Add(observer);
	}

	public void Detach(IObserver<T> observer)
	{
		_observers.Remove(observer);
	}

	public virtual void Notify(T updated)
	{
		foreach(var observer in _observers)
		{
			observer.Update(updated);
		}
	}
}