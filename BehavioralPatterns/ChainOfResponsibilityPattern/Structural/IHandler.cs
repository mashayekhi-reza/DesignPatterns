namespace ChainOfResponsibilityPattern.Structural;

public interface IHandler<T>
{
	void Handle(T request);

	IHandler<T> SetSuccessor(IHandler<T> successor);
}