namespace ProxyPattern.Example;

public class DocumentAccessControlProxy : IDocument
{
	private readonly string _userRole;
	private readonly LazyLoadingDocumentProxy _document;
	private readonly List<string> _allowedUserRoles = new()
	{
		"user",
		"admin"
	};

	public DocumentAccessControlProxy(string userRole)
	{
		_userRole = userRole;
		_document = new LazyLoadingDocumentProxy();
		Console.WriteLine("Document Access Controller is created!");
	}

	public void DisplayDocument()
	{
		if (_allowedUserRoles.Contains(_userRole))
		{
			_document.DisplayDocument();
		}
		else
		{
			Console.WriteLine("Access is not granted!");
		}
	}
}