namespace CompositePattern.Example
{
	public class Folder : ISystemItem
	{
		private readonly string _name;
		private readonly List<ISystemItem> _items = new();

		public Folder(string name)
		{
			_name = name;
		}

		public string Name => _name;

		public double GetSize() => _items.Sum(i => i.GetSize());

		public void AddItem(ISystemItem item) => _items.Add(item);
	}
}
