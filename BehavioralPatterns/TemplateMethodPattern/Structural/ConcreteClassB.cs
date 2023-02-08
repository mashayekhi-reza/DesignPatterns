namespace TemplateMethodPattern.Structural;

public class ConcreteClassB : AbstractClass
{
	protected override void PrimitiveOperation1() => Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");

	protected override void PrimitiveOperation2() => Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
}