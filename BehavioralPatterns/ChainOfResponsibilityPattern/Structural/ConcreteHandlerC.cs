﻿namespace ChainOfResponsibilityPattern.Structural;

public class ConcreteHandlerC : IHandler<int>
{
	private IHandler<int>? _successor;

	public void Handle(int request)
	{
		Console.WriteLine($"It is handled in {nameof(ConcreteHandlerC)}");
	}

	public void SetSuccessor(IHandler<int> successor)
	{
		_successor = successor;
	}
}