namespace CompositePattern.Structural
{
	public interface IComponent
	{
		public string Name { get; }

		public string Operation();
	}
}
