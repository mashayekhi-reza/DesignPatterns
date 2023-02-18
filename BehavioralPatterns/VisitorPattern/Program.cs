using VisitorPattern.SimplifiedStructural;
using VisitorPattern.Structural;

Console.WriteLine("Visitor Pattern");

StructuralImplementation();

SimplifiedStructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nVisitor Pattern Structural Implementation\n");

	var objectStructure = new ObjectStructure();

	objectStructure.Attach(new ConcreteElementA());
	objectStructure.Attach(new ConcreteElementB());

	objectStructure.Accept(new ConcreteVisitorA());
	objectStructure.Accept(new ConcreteVisitorB());
}

static void SimplifiedStructuralImplementation()
{
	Console.WriteLine("\nSimplified Visitor Pattern Structural Implementation\n");

	var objectStructure = new SimplifiedObjectStructure();

	objectStructure.Attach(new ConcreteSimplifiedElementA());
	objectStructure.Attach(new ConcreteSimplifiedElementB());

	objectStructure.Accept(new ConcreteSimplifiedVisitorA());
	objectStructure.Accept(new ConcreteSimplifiedVisitorB());
}