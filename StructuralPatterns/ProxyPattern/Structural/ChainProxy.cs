namespace ProxyPattern.Structural;

public class ChainProxy : ISubject
{
	private readonly ISubject _subject = new ThreadSafeLazyProxy();
	private readonly string _userRole;

	public ChainProxy(string userRole)
	{
		Console.WriteLine("Chain Proxy is created");
		_userRole = userRole;
	}

	public void Request()
	{
		if (_userRole == "Admin")
		{
			Console.WriteLine("Call from Chain Proxy:");
			_subject.Request();
		}
		else
		{
			Console.WriteLine("User is not Authorized!");
		}
	}
}
