namespace CompositePattern.Structural
{
	public class Composite : IComponent
	{
		private readonly List<IComponent> _components = new();

		private readonly string _name;

		public Composite(string name)
		{
			_name = name;
		}

		public string Name => _name;

		public string Operation()
		{
			return $"-> {_name} {string.Concat(_components.Select(c => $"\n{c.Operation()}"))}"
				.Replace("\n", "\n-");
		}

		public void Add(IComponent component)
		{
			_components.Add(component);
		}
	}
}
