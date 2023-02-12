using MementoPattern.Example;
using MementoPattern.Structural;

Console.WriteLine("Memento Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nMemento Pattern Structural Implementation\n");

	Originator originator = new();
	originator.SetState("On");

	CareTaker careTaker = new();
	careTaker.Memento = originator.CreateMemento();

	originator.SetState("Off");

	originator.RestoreMemento(careTaker.Memento);
}

static void ExampleImplementation()
{
	Console.WriteLine("\nMemento Pattern Example Implementation\n");

	var robot = new Robot();

	var robotMovementManager = new RobotMovementManager();

	robotMovementManager.ExecuteCommand(new RobotCommand(robot, 50));
	robotMovementManager.ExecuteCommand(new RobotCommand(robot, 20));
	robotMovementManager.Undo();

	Console.WriteLine("Out of range movement!");
	robotMovementManager.ExecuteCommand(new RobotCommand(robot, 120));
}