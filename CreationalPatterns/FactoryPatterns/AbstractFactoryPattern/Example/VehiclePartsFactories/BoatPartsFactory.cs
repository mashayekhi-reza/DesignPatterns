using AbstractFactoryPattern.Example.VehicleParts;

namespace AbstractFactoryPattern.Example.VehiclePartsFactories
{
	public class BoatPartsFactory : IVehiclePartsFactory
	{
		public IVehicleBody CreateBody()
		{
			return new BoatBody();
		}

		public IVehicleEngine CreateEngine()
		{
			return new BoatEngine();
		}
	}
}
