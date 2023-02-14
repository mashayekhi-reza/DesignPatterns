namespace ChainOfResponsibilityPattern.Structural;

public interface IHandler<T>
{
	void Handle(T request);

	void SetSuccessor(IHandler<T> successor);
}