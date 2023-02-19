namespace InterpreterPattern.Example;

public class BinaryContext
{
	public string Input { get; }
	public string Hexadecimal { get; set; } = string.Empty;
	public string Decimal { get; set; } = string.Empty;

	public BinaryContext(string input)
	{
		Input = input;
	}
}