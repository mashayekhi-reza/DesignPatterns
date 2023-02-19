namespace StrategyPattern.Structural;

public class ConcreteStrategyB : IStrategy
{
	public void AlgorithmInterface() => Console.WriteLine($"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
}