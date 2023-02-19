using CommandPattern.Example;
using CommandPattern.Structural;

Console.WriteLine("Command Pattern");

StructuralImplementation();

ExampleImplementation();

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

static void ExampleImplementation()
{
	Console.WriteLine("\nCommand Pattern Example Implementation\n");

	var robot = new Robot();

	var robotMovementManager = new RobotMovementManager();

	robotMovementManager.ExecuteCommand(new RightCommand(robot, 50));
	robotMovementManager.ExecuteCommand(new RightCommand(robot, 20));
	robotMovementManager.ExecuteCommand(new LeftCommand(robot, 10));
	robotMovementManager.ExecuteCommand(new LeftCommand(robot, 30));
	robotMovementManager.Undo();
	robotMovementManager.Undo();
	robotMovementManager.Undo();

	Console.WriteLine("Out of range movement!");
	robotMovementManager.ExecuteCommand(new RightCommand(robot, 150));
	robotMovementManager.ExecuteCommand(new LeftCommand(robot, 120));
}