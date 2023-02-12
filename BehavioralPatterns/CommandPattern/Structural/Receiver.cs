using System;

namespace CommandPattern.Structural;

public class Receiver
{
	public void Action()
	{
		Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
	}

	internal void UndoAction()
	{
		Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
	}
}