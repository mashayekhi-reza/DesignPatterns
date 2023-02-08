using TemplateMethodPattern.Structural;

Console.WriteLine("Template Method Pattern");

StructuralImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nTemplate Method Pattern Structural Implementation\n");

	var class1 = new ConcreteClassA();
	var class2 = new ConcreteClassB();

	class1.TemplateMethod();
	class2.TemplateMethod();
}