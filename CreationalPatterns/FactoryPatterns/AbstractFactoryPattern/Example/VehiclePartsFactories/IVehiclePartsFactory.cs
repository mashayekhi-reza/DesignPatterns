using AbstractFactoryPattern.Example.VehicleParts;

namespace AbstractFactoryPattern.Example.VehiclePartsFactories
{
	public interface IVehiclePartsFactory
	{
		IVehicleBody CreateBody();
		IVehicleEngine CreateEngine();
	}
}
