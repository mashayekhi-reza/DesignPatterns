using CommandPattern.Structural;

Console.WriteLine("Command Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nCommand Pattern Structural Implementation\n");

	var receiver = new Receiver();
	ICommand command = new ConcreteCommand(receiver);
	var invoker = new Invoker();

	invoker.SetCommand(command);
	invoker.ExecuteCommand();
	invoker.UndoCommand();
}