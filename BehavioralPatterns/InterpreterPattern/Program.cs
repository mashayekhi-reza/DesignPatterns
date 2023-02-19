using InterpreterPattern.Example;
using InterpreterPattern.Structural;

Console.WriteLine("Interpreter Pattern");

StructuralImplementation();

ExampleImplementation();

Console.ReadKey();

static void StructuralImplementation()
{
	Console.WriteLine("\nInterpreter Pattern Structural Implementation\n");

	var context = new Context();

	var expressions = new List<IExpression>();

	expressions.Add(new TerminalExpression());
	expressions.Add(new NonTerminalExpression());
	expressions.Add(new TerminalExpression());

	foreach(var expression in expressions)
	{
		expression.Interpret(context);
	}
}

static void ExampleImplementation()
{
	Console.WriteLine("\nInterpreter Pattern Example Implementation\n");

	var binaryContext = new BinaryContext("11110001");

	var expressions = new List<IBinaryExpression>
	{
		new HexadecimalExpression(),
		new DecimalExpression()
	};

	foreach (var expression in expressions)
	{
		expression.Interpret(binaryContext);
	}

	Console.WriteLine($"{binaryContext.Input} converted to " +
		$"Hexadecimal: {binaryContext.Hexadecimal} and " +
		$"Decimal: {binaryContext.Decimal}");
}