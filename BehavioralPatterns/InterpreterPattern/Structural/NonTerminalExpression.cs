namespace InterpreterPattern.Structural;

public class NonTerminalExpression : IExpression
{
	public void Interpret(Context context)
	{
		Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
	}
}