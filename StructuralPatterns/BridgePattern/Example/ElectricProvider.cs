namespace BridgePattern.Example
{
	public class ElectricProvider : IFuelProvider
	{
		public string Fillup()
		{
			return "Filled up with Electric";
		}
	}
}
