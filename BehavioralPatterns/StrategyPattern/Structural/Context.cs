namespace StrategyPattern.Structural;

public class Context
{
	private readonly IStrategy _strategy;

	public Context(IStrategy strategy) => _strategy = strategy;

	public void ContextInterface() => _strategy.AlgorithmInterface();
}