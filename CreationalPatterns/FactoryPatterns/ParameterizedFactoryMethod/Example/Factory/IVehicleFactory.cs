using ParameterizedFactoryMethod.Example.Vehicles;

namespace ParameterizedFactoryMethod.Example.Factory
{
	public interface IVehicleFactory
	{
		IVehicle CreateVehicle(string key);
	}
}
