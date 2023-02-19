namespace InterpreterPattern.Example;

public class DecimalExpression : IBinaryExpression
{
	public void Interpret(BinaryContext binaryContext)
	{
		binaryContext.Decimal = Convert.ToInt32(binaryContext.Input, 2).ToString(); ;
	}
}