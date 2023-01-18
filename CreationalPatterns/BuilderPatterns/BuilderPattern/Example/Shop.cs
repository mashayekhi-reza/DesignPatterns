namespace BuilderPattern.RealWorldExample
{
	public class Shop
	{
		public void Construct(IVehicleBuilder vehicleBuilder)
		{
			vehicleBuilder.SetType();
			vehicleBuilder.SetBrand();
			vehicleBuilder.AddEngine();
			vehicleBuilder.AddBody();
		}
	}
}
