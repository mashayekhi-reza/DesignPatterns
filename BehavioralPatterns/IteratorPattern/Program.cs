using IteratorPattern.Structural;

Console.WriteLine("Iterator Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nIterator Pattern Structural Implementation\n");

	var concreteAggregate = new ConcreteAggregate();
	concreteAggregate.Add("Item A");
	concreteAggregate.Add("Item B");
	concreteAggregate.Add("Item C");
	concreteAggregate.Add("Item D");

	IIterator iterator = concreteAggregate.CreateIterator();

	Console.WriteLine("Start Iterating");

	for(var obj = iterator.First(); !iterator.IsDone(); obj = iterator.Next())
	{
		Console.WriteLine(obj);
	}
}