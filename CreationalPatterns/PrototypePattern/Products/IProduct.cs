namespace PrototypePattern.Products
{
	public interface IProduct
	{
		string Name { get; }
		List<string> Sections { get; }

		void AddSection(string section);
		void ChangeName(string name);
		IProduct Clone();
	}
}