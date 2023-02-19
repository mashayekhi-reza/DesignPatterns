using InterpreterPattern.Structural;

Console.WriteLine("Interpreter Pattern");

StructuralImplementation();

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