// See https://aka.ms/new-console-template for more information
using CompositePattern.Structural;

Console.WriteLine("Composite Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nComposite Pattern Structural Implementation\n");

	var root = new Composite("root");
	root.Add(new Leaf("root leaf"));

	var compositeA = new Composite("compositeA");
	compositeA.Add(new Leaf("compositeA leaf1"));
	compositeA.Add(new Leaf("compositeA leaf2"));

	var compositeB = new Composite("compositeB");
	compositeB.Add(new Leaf("compositeB leaf1"));

	compositeA.Add(compositeB);

	root.Add(compositeA);

	Console.WriteLine(root.Operation());

}
