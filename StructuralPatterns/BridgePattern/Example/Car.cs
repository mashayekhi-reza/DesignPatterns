namespace BridgePattern.Example
{
	public class Car : Vehicle
	{
		public Car(IFuelProvider fuelProvider) : base(fuelProvider)
		{
		}

		public override string FullupTank()
		{
			return $"Car is {_fuelProvider.Fillup()}";
		}
	}
}
