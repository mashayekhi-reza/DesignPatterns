namespace InterpreterPattern.Example;

public class HexadecimalExpression : IBinaryExpression
{
	public void Interpret(BinaryContext binaryContext)
	{
		binaryContext.Hexadecimal = string.Format("{0:X2}", Convert.ToUInt64(binaryContext.Input, 2));
	}
}