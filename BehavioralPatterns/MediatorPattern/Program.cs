using MediatorPattern.Structural;

Console.WriteLine("Mediator Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nMediator Pattern Structural Implementation\n");

	var mediator = new ConcreteMediator();

	var colleagueA = new ConcreteColleagueA(mediator);
	var colleagueB = new ConcreteColleagueB(mediator);

	mediator.SetColleagueA(colleagueA);
	mediator.SetColleagueB(colleagueB);

	colleagueA.Send($"A Message from me, {nameof(colleagueA)}.");
	colleagueB.Send($"A Message from me, {nameof(colleagueB)}.");
}