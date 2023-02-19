namespace FlyweightPattern.Structural;

public class FlyweightFactory
{
	private readonly Dictionary<string, IFlyweight> _flyweights = new();

	public IFlyweight GetFlyweight(string key)
	{
		if (!_flyweights.ContainsKey(key))
		{
			_flyweights.Add(key, new ConcreteFlyweight());
		}

		return _flyweights[key];
	}

	public IFlyweight GetUnsharedFlyweight() => new UnsharedConcreteFlyweight();
}