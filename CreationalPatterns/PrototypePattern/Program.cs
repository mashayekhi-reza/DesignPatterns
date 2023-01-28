// See https://aka.ms/new-console-template for more information
using PrototypePattern.Products;

Console.WriteLine("Prototype Pattern");

ShallowCopyImplementation();

DeepCopyImplementation();

Console.ReadKey();

static void PrintProduct(IProduct product, string parameterName)
{
	Console.WriteLine($"{parameterName}, Name: {product.Name}, section(s): {string.Join(", ", product.Sections)}");
}

static void ShallowCopyImplementation()
{
	Console.WriteLine("Shallow Copy\n");

	Console.WriteLine("\nSections are not changed after cloning!");

	IProduct shallowMainProduct = new ShallowCopyProduct("Main");
	IProduct shallowCopyProduct = (ShallowCopyProduct)shallowMainProduct.Clone();

	PrintProduct(shallowMainProduct, nameof(shallowMainProduct));
	PrintProduct(shallowCopyProduct, nameof(shallowCopyProduct));

	Console.WriteLine("\nMain object name and sections are changed after cloning, then the cloned object name remains unchanged but the sections are affected!");

	shallowMainProduct.ChangeName("New Main Name");
	shallowMainProduct.AddSection("Section1");
	shallowMainProduct.AddSection("Section2");

	PrintProduct(shallowMainProduct, nameof(shallowMainProduct));
	PrintProduct(shallowCopyProduct, nameof(shallowCopyProduct));

	Console.WriteLine("\nClone object name and sections are changed, then the main object sections are affected, but not its name!");

	shallowCopyProduct.ChangeName("Clone Object Name");
	shallowCopyProduct.AddSection("Section3");
	shallowCopyProduct.AddSection("Section4");

	PrintProduct(shallowMainProduct, nameof(shallowMainProduct));
	PrintProduct(shallowCopyProduct, nameof(shallowCopyProduct));
}

static void DeepCopyImplementation()
{
	Console.WriteLine("\nDeep Copy\n");

	Console.WriteLine("\nSections are not changed after cloning!");

	IProduct deepCopyMainObject = new DeepCopyProduct("Main");
	IProduct deepCopyClonedObject = (DeepCopyProduct)deepCopyMainObject.Clone();

	PrintProduct(deepCopyMainObject, nameof(deepCopyMainObject));
	PrintProduct(deepCopyClonedObject, nameof(deepCopyClonedObject));

	Console.WriteLine("\nMain object name and sections are changed after cloning, then the cloned object properties remain unchanged!");

	deepCopyMainObject.ChangeName("New Main Name");
	deepCopyMainObject.AddSection("Section1");
	deepCopyMainObject.AddSection("Section2");

	PrintProduct(deepCopyMainObject, nameof(deepCopyMainObject));
	PrintProduct(deepCopyClonedObject, nameof(deepCopyClonedObject));

	Console.WriteLine("\nClone object name and sections are changed, then the main object properties remain unchanged!");

	deepCopyClonedObject.ChangeName("Clone Object Name");
	deepCopyClonedObject.AddSection("Section3");
	deepCopyClonedObject.AddSection("Section4");

	PrintProduct(deepCopyMainObject, nameof(deepCopyMainObject));
	PrintProduct(deepCopyClonedObject, nameof(deepCopyClonedObject));
}