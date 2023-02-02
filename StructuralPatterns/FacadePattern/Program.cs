// See https://aka.ms/new-console-template for more information
using FacadePattern.Example;
using FacadePattern.Structural;

Console.WriteLine("Facade Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nFacade Pattern Structural Implementation\n");

	var firstSubSystem = new FirstSubSystem();
	var secondSubSystem = new SecondSubSystem();

	var facade = new Facade(firstSubSystem, secondSubSystem);

	Console.WriteLine("Call Facade First Method:");
	Console.WriteLine(facade.FirstFacadeMethod());

	Console.WriteLine("Call Facade Second Method:");
	Console.WriteLine(facade.SecondFacadeMethod());
}

static void ExampleImplementation()
{
	Console.WriteLine("\nFacade Pattern Example Implementation\n");

	var accountStatusService = new AccountStatusService();
	var accountFundService = new AccountFundService();

	var atmService = new AtmService(accountStatusService, accountFundService);

	Console.WriteLine($"AccountA, Withdraw 100, response: {atmService.Withdraw("AccountA", 100)}");
	Console.WriteLine($"AccountB, Withdraw 150, response: {atmService.Withdraw("AccountB", 150)}");
	Console.WriteLine($"AccountB, Withdraw 100, response: {atmService.Withdraw("AccountB", 100)}");
}
