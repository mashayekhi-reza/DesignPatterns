// See https://aka.ms/new-console-template for more information
using CompositePattern.Example;
using CompositePattern.Structural;
using File = CompositePattern.Example.File;

Console.WriteLine("Composite Pattern");

StructuralImplementation();

ExampleImplementation();

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

static void ExampleImplementation()
{
	Console.WriteLine("\nComposite Pattern Example Implementation\n");

	var firstFolder = new Folder("firstFolder");
	firstFolder.AddItem(new File("file1", 1));
	firstFolder.AddItem(new File("file2", 2));

	var secondFolder = new Folder("secondFolder");
	secondFolder.AddItem(new File("file3", 3));
	secondFolder.AddItem(new File("file4", 4));


	var thirdFolder = new Folder("thirdFolder");

	secondFolder.AddItem(thirdFolder);
	firstFolder.AddItem(secondFolder);

	PrintFoldersSize(firstFolder, secondFolder, thirdFolder);

	Console.WriteLine("\nAdd one file to second folder and one to third folder\n");
	secondFolder.AddItem(new File("file5", 5));
	thirdFolder.AddItem(new File("file6", 6));

	PrintFoldersSize(firstFolder, secondFolder, thirdFolder);
}

static void PrintFoldersSize(Folder firstFolder, Folder secondFolder, Folder thirdFolder)
{
	Console.WriteLine($"{nameof(firstFolder)}, Size: {firstFolder.GetSize()}");
	Console.WriteLine($"{nameof(secondFolder)}, Size: {secondFolder.GetSize()}");
	Console.WriteLine($"{nameof(thirdFolder)}, Size: {thirdFolder.GetSize()}");
}