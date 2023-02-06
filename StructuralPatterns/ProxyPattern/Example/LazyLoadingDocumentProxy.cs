namespace ProxyPattern.Example;

public class LazyLoadingDocumentProxy : IDocument
{
	private readonly Lazy<IDocument> _document;

	public LazyLoadingDocumentProxy()
	{
		_document = new(() => new Document());
		Console.WriteLine("Lazy Loading Document is created!");
	}

	public void DisplayDocument() => _document.Value.DisplayDocument();
}