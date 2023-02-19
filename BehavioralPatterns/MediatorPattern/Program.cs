using MediatorPattern.Example;
using MediatorPattern.Structural;

Console.WriteLine("Mediator Pattern");

StructuralImplementation();

ExampleImplementation();

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

static void ExampleImplementation()
{
	Console.WriteLine("\nMediator Pattern Example Implementation\n");

	var engineer1 = new Engineer("Engineer1");
	var engineer2 = new Engineer("Engineer2");
	var engineer3 = new Engineer("Engineer3");
	var manager1 = new Manager("Manager1");
	var manager2 = new Manager("Manager2");

	var chatRoom = new ChatRoom();

	chatRoom.Register(engineer1);
	chatRoom.Register(engineer2);
	chatRoom.Register(engineer3);
	chatRoom.Register(manager1);
	chatRoom.Register(manager2);

	Console.WriteLine("Message to all:");
	engineer1.Send("message1");
	manager1.Send("message2");

	Console.WriteLine("Message to engineers:");
	engineer1.SendToRole<Engineer>("message3");
}