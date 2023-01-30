namespace BridgePattern.Example
{
	public abstract class Vehicle
	{
		protected readonly IFuelProvider _fuelProvider;

		public Vehicle(IFuelProvider fuelProvider)
		{
			_fuelProvider = fuelProvider;
		}

		public abstract string FullupTank();
	}
}
