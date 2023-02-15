using ObserverPattern.Structural;

Console.WriteLine("Observer Pattern");

StructuralImplementation();

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