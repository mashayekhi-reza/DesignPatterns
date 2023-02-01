namespace CompositePattern.Structural
{
	public class Leaf : IComponent
	{
		private readonly string _name;

		public Leaf(string name)
		{
			_name = name;
		}

		public string Name => _name;

		public string Operation()
		{
			return $"-> {_name}";
		}
	}
}
