namespace PrototypePattern.Products
{
	public abstract class Product : IProduct
	{
		private string _name;

		private List<string> _sections;

		public Product(string name)
		{
			_name = name;
			_sections = new List<string>();
		}

		public List<string> Sections => _sections;

		public string Name => _name;

		public void AddSection(string section)
		{
			_sections.Add(section);
		}

		public void ChangeName(string name)
		{
			_name = name;
		}

		public abstract IProduct Clone();
	}
}
