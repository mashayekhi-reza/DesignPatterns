namespace TemplateMethodPattern.Structural;

public class ConcreteClassA : AbstractClass
{
	public override void PrimitiveOperation1() => Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");

	public override void PrimitiveOperation2() => Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
}