namespace MediatorPattern.Structural;

public interface IMediator
{
	void Send(string message, Colleague colleague);
}