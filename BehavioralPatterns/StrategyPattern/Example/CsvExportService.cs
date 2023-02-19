namespace StrategyPattern.Example;

public class CsvExportService : IExportService
{
	public void Export(Document document) => Console.WriteLine($"Export generated from {GetType().Name}:\n{document.Title}, {document.Body}");
}