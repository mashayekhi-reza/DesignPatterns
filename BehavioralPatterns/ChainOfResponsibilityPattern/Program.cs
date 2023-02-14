using ChainOfResponsibilityPattern.Example;
using ChainOfResponsibilityPattern.Structural;

Console.WriteLine("Chain of Responsibility Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nChain of Responsibility Pattern Structural Implementation\n");

	IHandler<int> handlerA = new ConcreteHandlerA();
	IHandler<int> handlerB = new ConcreteHandlerB();
	IHandler<int> handlerC = new ConcreteHandlerC();
    handlerA.SetSuccessor(handlerB)
        .SetSuccessor(handlerC);

    var requests = new int[] { 2, 5, 14, 22, 118, 3, 27, 20 };
    foreach (int request in requests)
    {
        handlerA.Handle(request);
    }
}

static void ExampleImplementation()
{
	Console.WriteLine("\nChain of Responsibility Pattern Example Implementation\n");

	var titleHander = new DocumentTitleHandler();
	var bodyHandler = new DocumentBodyHandler();
	titleHander.SetSuccessor(bodyHandler);

	var documentA = new Document("", "body");
	var documentB = new Document("title", "");
	var documentC = new Document("title", "body");

	ValidateDocument(titleHander, documentA);
	ValidateDocument(titleHander, documentB);
	ValidateDocument(titleHander, documentC);
}

static void ValidateDocument(IHandler<Document> titleHander, Document document)
{
	Console.WriteLine($"Title: {document.Title}, Body: {document.Body}");
	try
	{
		titleHander.Handle(document);
		Console.WriteLine("The document is valid\n");
	}
	catch (Exception ex)
	{
		Console.WriteLine($"{ex.Message}\n");
	}
}