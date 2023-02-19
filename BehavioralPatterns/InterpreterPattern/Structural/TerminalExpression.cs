namespace InterpreterPattern.Structural;

public class TerminalExpression : IExpression
{
	public void Interpret(Context context)
	{
		Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
	}
}