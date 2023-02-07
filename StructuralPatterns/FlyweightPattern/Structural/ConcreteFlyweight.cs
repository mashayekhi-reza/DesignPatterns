namespace FlyweightPattern.Structural;

public class ConcreteFlyweight : IFlyweight
{
	public int IntrinsicState { get; }

	public ConcreteFlyweight()
	{
		IntrinsicState = Random.Shared.Next(1, 100);
	}

	public void Operation(string extrinsicstate)
	{
		Console.WriteLine($"Intrinsic State is {IntrinsicState}, and extrinsic state is {extrinsicstate}");
	}
}