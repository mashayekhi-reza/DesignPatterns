using MementoPattern.Structural;

Console.WriteLine("Memento Pattern");

StructuralImplementation();

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


