using VisitorPattern.Example;
using VisitorPattern.SimplifiedStructural;
using VisitorPattern.Structural;

Console.WriteLine("Visitor Pattern");

StructuralImplementation();

SimplifiedStructuralImplementation();

ExampleImplementation();

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

static void ExampleImplementation()
{
	Console.WriteLine("\nVisitor Pattern Example Implementation\n");

	var employees = new Employees();

	employees.Attach(new Engineer("Engineer1", 10000));
	employees.Attach(new Engineer("Engineer2", 20000));
	employees.Attach(new Manager("Manager1", 10000));
	employees.Attach(new Manager("Manager2", 20000));

	employees.Accept(new IncreaseIncomeVisitor());
	employees.Accept(new VacationVisitor());
}