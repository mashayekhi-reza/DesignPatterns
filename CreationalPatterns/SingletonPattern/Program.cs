// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Singleton Pattern");

Console.WriteLine("\nSingleton With Eager Initialization\n");
var singletonWithEagerInitialization1 = SingletonWithEagerInitialization.Instance;
var singletonWithEagerInitialization2 = SingletonWithEagerInitialization.Instance;
CompareObjects(singletonWithEagerInitialization1, singletonWithEagerInitialization2);

Console.WriteLine("\nSingleton With Lazy Initialization\n");
var singletonWithLazyInitialization1 = SingletonWithLazyInitialization.Instance;
var singletonWithLazyInitialization2 = SingletonWithLazyInitialization.Instance;
CompareObjects(singletonWithLazyInitialization1, singletonWithLazyInitialization2);

Console.WriteLine("\nSingleton Thread Safe With Lazy Initialization\n");
var singletonThreadSafeWithLazyInitialization1 = SingletonThreadSafeWithLazyInitialization.Instance;
var singletonThreadSafeWithLazyInitialization2 = SingletonThreadSafeWithLazyInitialization.Instance;
CompareObjects(singletonThreadSafeWithLazyInitialization1, singletonThreadSafeWithLazyInitialization2);

Console.ReadKey();

static void CompareObjects(object object1, object object2)
{
	if (object1 == object2)
	{
		Console.WriteLine("They are the same!");
	}
	else
	{
		Console.WriteLine("They are not the same!");
	}
}