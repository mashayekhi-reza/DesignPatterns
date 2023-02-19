using ChainOfResponsibilityPattern.Structural;
using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibilityPattern.Example;

public class DocumentBodyHandler : IHandler<Document>
{
	private IHandler<Document>? _successor;

	public void Handle(Document document)
	{
		if (string.IsNullOrEmpty(document.Body))
		{
			throw new ValidationException(
				new ValidationResult(
					"Body must be filled out",
					new List<string>() { "Body" }), null, null);
		}
		_successor?.Handle(document);
	}

	public IHandler<Document> SetSuccessor(IHandler<Document> successor)
	{
		_successor = successor;
		return successor;
	}
}