using FlyweightPattern.Structural;

Console.WriteLine("Flyweight Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nFlyweight Pattern Structural Implementation\n");

	var factory = new FlyweightFactory();

	Console.WriteLine("The key is A and the extrinsic state is 1:");
	factory.GetFlyweight("A").Operation("1");

	Console.WriteLine("The key is B and the extrinsic state is 2:");
	factory.GetFlyweight("B").Operation("2");

	Console.WriteLine("The key is C and the extrinsic state is 3:");
	factory.GetFlyweight("C").Operation("3");

	Console.WriteLine("The key is A and the extrinsic state is 4:");
	factory.GetFlyweight("A").Operation("4");

	Console.WriteLine("Unshare Flyweight and the extrinsic state is 5:");
	factory.GetUnsharedFlyweight().Operation("5");

	Console.WriteLine("Unshare Flyweight and the extrinsic state is 6:");
	factory.GetUnsharedFlyweight().Operation("6");
}