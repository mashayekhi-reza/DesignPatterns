// See https://aka.ms/new-console-template for more information
using FacadePattern.Structural;

Console.WriteLine("Facade Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nFacade Pattern Structural Implementation\n");

	var firstSubSystem = new FirstSubSystem();
	var secondSubSystem = new SecondSubSystem();

	var facade = new Facade(firstSubSystem, secondSubSystem);

	Console.WriteLine("Call Facade First Method:");
	Console.WriteLine(facade.FirstFacadeMethod());

	Console.WriteLine("Call Facade Second Method:");
	Console.WriteLine(facade.SecondFacadeMethod());
}
