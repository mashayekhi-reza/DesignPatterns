namespace FluentBuilderPattern.Example
{
	public class Vehicle
	{
		private readonly Dictionary<string, string> _parts = new();
		public string Type { get; set; }
		public string Brand { get; set; }
		public void AddPart(string type, string value)
		{
			_parts[type] = value;
		}
		public Dictionary<string, string> GetParts() => _parts;
	}
}
