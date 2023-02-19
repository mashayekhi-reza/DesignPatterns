using IteratorPattern.Example;
using IteratorPattern.Structural;

Console.WriteLine("Iterator Pattern");

StructuralImplementation();

ExampleImplementation();

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

static void ExampleImplementation()
{
	Console.WriteLine("\nIterator Pattern Example Implementation\n");

	var musicCollection = new MusicCollection();
	musicCollection.Add(new Music("First Music", "First Music Singer"));
	musicCollection.Add(new Music("Second Music", "Second Music Singer"));
	musicCollection.Add(new Music("Third Music", "Third Music Singer"));


	var musicIterator = musicCollection.CreateIterator();

	for(var music = musicIterator.First(); !musicIterator.IsDone(); music = musicIterator.Next())
	{
		Console.WriteLine($"Music name: {music?.Name}, Singer: {music?.Singer}");
	}
}