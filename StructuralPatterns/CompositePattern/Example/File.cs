namespace CompositePattern.Example
{
	public class File : ISystemItem
	{
		private readonly string _name;
		private readonly double _size;

		public File(string name, double size)
		{
			_name = name;
			_size = size;
		}

		public string Name => _name;

		public double GetSize() => _size;
	}
}
