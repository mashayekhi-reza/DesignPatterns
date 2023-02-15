namespace Observer_Pattern.Structural;

public interface IObserver<T>
{
	void Update(T updated);
}