// See https://aka.ms/new-console-template for more information
using AdapterPattern.ClassAdapter;
using AdapterPattern.ObjectAdapter;
using AdapterPattern.ObjectAdapterWithInjection;

Console.WriteLine("Adapter Pattern");

ClassAdapterImplementation();

ObjectAdapterImplementation();

ObjectAdapterWithInjectionImplementation();

Console.ReadKey();

static void ClassAdapterImplementation()
{
	Console.WriteLine("\nClass Adapter Implementation\n");

	ITargetC target = new AdapterC();

	Console.WriteLine(target.Request());
}

static void ObjectAdapterImplementation()
{
	Console.WriteLine("\nObject Adapter Implementation\n");

	ITargetO target = new AdapterO();

	Console.WriteLine(target.Request());
}

static void ObjectAdapterWithInjectionImplementation()
{
	Console.WriteLine("\nObject Adapter With Injection Implementation\n");

	IAdapteeOI adapteeOI = new AdapteeOI();
	ITargetOI target = new AdapterOI(adapteeOI);

	Console.WriteLine(target.Request());
}

