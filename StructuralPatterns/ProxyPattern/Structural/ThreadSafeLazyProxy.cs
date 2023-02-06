namespace ProxyPattern.Structural;

public class ThreadSafeLazyProxy : ISubject
{
	private Lazy<ISubject> _subject = new(() => new RealSubject());

	public ThreadSafeLazyProxy()
	{
		Console.WriteLine("Thread Safe Lazy Proxy is created");
	}

	public void Request()
	{
		Console.WriteLine("Call from Thread Safe Lazy Proxy:");
		_subject.Value.Request();
	}
}
