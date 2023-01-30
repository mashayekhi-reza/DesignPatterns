// See https://aka.ms/new-console-template for more information
using BridgePattern.Example;
using BridgePattern.Structural;

Console.WriteLine("Bridge Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nBridge Pattern Structural Implementation\n");

	IImplementor concreteImplementorA = new ConcreteImplementorA();

	Abstraction refinedAbstractionA = new RefinedAbstractionA(concreteImplementorA);

	Console.WriteLine(refinedAbstractionA.Operation());

	IImplementor concreteImplementorB = new ConcreteImplementorB();

	Abstraction refinedAbstractionB = new RefinedAbstractionB(concreteImplementorB);

	Console.WriteLine(refinedAbstractionB.Operation());
}

static void ExampleImplementation()
{
	Console.WriteLine("\nBridge Pattern Example Implementation\n");

	IFuelProvider gasProvider = new GasProvider();
	IFuelProvider electricProvider = new ElectricProvider();

	Vehicle petrolCar = new Car(gasProvider);
	Console.WriteLine($"{nameof(petrolCar)}: {petrolCar.FullupTank()}");

	Vehicle electricCar = new Car(electricProvider);
	Console.WriteLine($"{nameof(electricCar)}: {electricCar.FullupTank()}");
}