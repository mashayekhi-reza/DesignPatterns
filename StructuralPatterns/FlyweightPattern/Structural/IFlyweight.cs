namespace FlyweightPattern.Structural;

public interface IFlyweight
{
	int IntrinsicState { get; }

	void Operation(string extrinsicstate);
}