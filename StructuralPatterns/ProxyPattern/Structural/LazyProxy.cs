namespace ProxyPattern.Structural;

public class LazyProxy : ISubject
{
	private ISubject? _subject;

	public LazyProxy()
	{
		Console.WriteLine("Lazy Proxy is created");
	}


	public void Request()
	{
		Console.WriteLine("Call from Lazy Proxy:");

		if(_subject == null)
		{
			_subject = new RealSubject();
		}

		_subject.Request();
	}
}
