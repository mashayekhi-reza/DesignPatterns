namespace FlyweightPattern.Example;

public class Paragraph : IDocumentItem
{
	private readonly string _text;
	private int _fontSize;

	public Paragraph(string text)
	{
		Console.WriteLine($"{GetType().Name} created!");
		_text = text;
	}

	public void Print(int fontSize)
	{
		_fontSize = fontSize;
		Console.WriteLine($"Paragraph {_text}, font size: {_fontSize}.");
	}
}