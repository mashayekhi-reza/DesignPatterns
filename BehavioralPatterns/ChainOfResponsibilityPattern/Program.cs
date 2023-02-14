using ChainOfResponsibilityPattern.Structural;

Console.WriteLine("Chain of Responsibility Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nChain of Responsibility Pattern Structural Implementation\n");

	IHandler<int> handlerA = new ConcreteHandlerA();
	IHandler<int> handlerB = new ConcreteHandlerB();
	IHandler<int> handlerC = new ConcreteHandlerC();
    handlerA.SetSuccessor(handlerB)
        .SetSuccessor(handlerC);

    var requests = new int[] { 2, 5, 14, 22, 118, 3, 27, 20 };
    foreach (int request in requests)
    {
        handlerA.Handle(request);
    }
}
