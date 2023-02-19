namespace StrategyPattern.Example;

public class Document
{
	public string Title { get; }
	public string Body { get; }

	public Document( string title, string body)
	{
		Title = title;
		Body = body;
	}

	public void Export(IExportService exportService) => exportService.Export(this);
}