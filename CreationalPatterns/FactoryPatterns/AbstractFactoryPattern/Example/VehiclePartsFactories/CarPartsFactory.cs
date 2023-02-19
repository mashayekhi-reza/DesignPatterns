using AbstractFactoryPattern.Example.VehicleParts;

namespace AbstractFactoryPattern.Example.VehiclePartsFactories
{
	public class CarPartsFactory : IVehiclePartsFactory
	{
		public IVehicleBody CreateBody()
		{
			return new CarBody();
		}

		public IVehicleEngine CreateEngine()
		{
			return new CarEngine();
		}
	}
}
