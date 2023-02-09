namespace StrategyPattern.Structural;

public class ConcreteStrategyA : IStrategy
{
	public void AlgorithmInterface() => Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
}