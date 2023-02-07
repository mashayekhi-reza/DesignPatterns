namespace FlyweightPattern.Example;

public abstract class Character : IDocumentItem
{
	protected char _char;
	private int _fontSize;

	public Character()
	{
		Console.WriteLine($"{GetType().Name} created!");
	}

	public void Print(int fontSize)
	{
		_fontSize = fontSize;

		Console.WriteLine($"Char {_char}, font size: {_fontSize}.");
	}
}