namespace ProxyPattern.Structural;

public class ThreadSafeLazyProxy : ISubject
{
	private readonly Lazy<ISubject> _subject;

	public ThreadSafeLazyProxy()
	{
		_subject = new(() => new RealSubject());
		Console.WriteLine("Thread Safe Lazy Proxy is created");
	}

	public void Request()
	{
		Console.WriteLine("Call from Thread Safe Lazy Proxy:");
		_subject.Value.Request();
	}
}
