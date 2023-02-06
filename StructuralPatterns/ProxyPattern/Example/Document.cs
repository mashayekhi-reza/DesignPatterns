namespace ProxyPattern.Example;

public class Document : IDocument
{
	public Document() => Console.WriteLine("Document is created!");

	public void DisplayDocument() => Console.WriteLine("Document is displayed!");
}