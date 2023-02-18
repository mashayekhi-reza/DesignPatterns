using VisitorPattern.Structural;

Console.WriteLine("Visitor Pattern");

StructuralImplementation();

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