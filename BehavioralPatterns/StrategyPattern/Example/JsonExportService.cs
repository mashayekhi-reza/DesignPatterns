namespace StrategyPattern.Example;

public class JsonExportService : IExportService
{
	public void Export(Document document) => Console.WriteLine($"Export generated from {GetType().Name}:\n{{\"Title\":\"{document.Title}\",\"Body\":\"{document.Body}\"}}");
}