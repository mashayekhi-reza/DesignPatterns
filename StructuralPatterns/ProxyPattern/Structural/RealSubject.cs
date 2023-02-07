namespace ProxyPattern.Structural;

public class RealSubject : ISubject
{
	public RealSubject()
	{
		Console.WriteLine("Real Subject Created");
	}
	public void Request() => Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
}
