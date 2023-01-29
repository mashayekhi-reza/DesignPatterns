namespace BuilderPattern.Structural 
{
	public class Product
	{
		private readonly List<string> _parts = new();

		public void AddPart(string part)
		{
			_parts.Add(part);
		}

		public List<string> GetParts() => _parts;
	}
}