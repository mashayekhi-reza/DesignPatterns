using ObserverPattern.Example;
using ObserverPattern.Structural;

Console.WriteLine("Observer Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nObserver Pattern Structural Implementation\n");

	var subject = new ConcreteSubject("First Subject Name");

	var observerA = new ConcreteObserverA("ObserverA Name");
	var observerB = new ConcreteObserverB("ObserverB Name");

	subject.Attach(observerA);
	subject.Attach(observerB);

	Console.WriteLine("Change the subject name to NewNameA");
	subject.ChangeName("NewNameA");

	Console.WriteLine("\nRemove observerB and change name to NewNameB");
	subject.Detach(observerB);
	subject.ChangeName("NewNameB");

}

static void ExampleImplementation()
{
	Console.WriteLine("\nObserver Pattern Example Implementation\n");

	var engineersChannel = new EngineersChannel();
	var managersChannel = new ManagerChannel();

	var generalEventsService = new CompanyEventService();
	generalEventsService.Attach(managersChannel);
	generalEventsService.Attach(engineersChannel);

	var engineersEventsService = new CompanyEventService();
	engineersEventsService.Attach(engineersChannel);

	generalEventsService.AnnounceEvent("New General Event for Everyone", 200);

	Console.WriteLine();
	engineersEventsService.AnnounceEvent("New Technical Event for Engineers", 100);
}