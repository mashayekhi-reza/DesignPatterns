﻿using ChainOfResponsibilityPattern.Structural;
using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibilityPattern.Example;

public class DocumentTitleHandler : IHandler<Document>
{
	private IHandler<Document>? _successor;

	public void Handle(Document document)
	{
		if (string.IsNullOrEmpty(document.Title))
		{
			throw new ValidationException(
				new ValidationResult(
					"Title must be filled out",
					new List<string>() { "Title" }), null, null);
		}
		_successor?.Handle(document);
	}

	public IHandler<Document> SetSuccessor(IHandler<Document> successor)
	{
		_successor = successor;
		return successor;
	}
}