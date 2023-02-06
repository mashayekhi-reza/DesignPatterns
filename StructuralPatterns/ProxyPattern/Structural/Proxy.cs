namespace ProxyPattern.Structural;

public class Proxy : ISubject
{
	private readonly ISubject _subject = new RealSubject();

	public Proxy()
	{
		Console.WriteLine("Proxy is created");
	}

	public void Request()
	{
		Console.WriteLine("Call from Proxy:");
		_subject.Request();
	}
}
