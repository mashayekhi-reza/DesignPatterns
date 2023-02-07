namespace FlyweightPattern.Structural;

public class UnsharedConcreteFlyweight : IFlyweight
{
	public int IntrinsicState { get; }

	public UnsharedConcreteFlyweight()
	{
		IntrinsicState = Random.Shared.Next(1, 100);
	}

	public void Operation(string extrinsicstate)
	{
		Console.WriteLine($"From Unshared: Intrinsic State is {IntrinsicState}, and extrinsic state is {extrinsicstate}");
	}
}