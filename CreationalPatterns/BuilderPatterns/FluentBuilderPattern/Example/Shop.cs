namespace FluentBuilderPattern.Example
{
	public class Shop
	{
		public void Construct(IVehicleBuilder vehicleBuilder)
		{
			vehicleBuilder
				.SetType()
				.SetBrand()
				.AddEngine()
				.AddBody();
		}
	}
}
