using StrategyPattern.Example;
using StrategyPattern.Structural;

Console.WriteLine("Strategy Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nStrategy Pattern Structural Implementation\n");

	var concreteStrategyA = new ConcreteStrategyA();
	var contextA = new Context(concreteStrategyA);
	contextA.ContextInterface();

	var concreteStrategyB = new ConcreteStrategyB();
	var contextB = new Context(concreteStrategyB);
	contextB.ContextInterface();
}

static void ExampleImplementation()
{
	Console.WriteLine("\nStrategy Pattern Example Implementation\n");

	var document = new Document("The document title", "This is the document body!");

	document.Export(new CsvExportService());

	document.Export(new JsonExportService());
}

