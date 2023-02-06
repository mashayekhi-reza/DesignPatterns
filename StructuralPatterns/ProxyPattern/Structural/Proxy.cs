namespace ProxyPattern.Structural;

public class Proxy : ISubject
{
	private readonly ISubject _subject;

	public Proxy()
	{
		_subject = new RealSubject();
		Console.WriteLine("Proxy is created");
	}

	public void Request()
	{
		Console.WriteLine("Call from Proxy:");
		_subject.Request();
	}
}
