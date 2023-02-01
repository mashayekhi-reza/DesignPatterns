namespace CompositePattern.Structural
{
	public interface IComponent
	{
		string Name { get; }

		string Operation();
	}
}
