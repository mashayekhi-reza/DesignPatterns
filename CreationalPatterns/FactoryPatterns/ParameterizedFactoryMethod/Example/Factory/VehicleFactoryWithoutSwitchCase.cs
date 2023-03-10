using ParameterizedFactoryMethod.Example.Vehicles;

namespace ParameterizedFactoryMethod.Example.Factory;

public class VehicleFactoryWithoutSwitchCase : IVehicleFactory
{
	private readonly Dictionary<string, Func<IVehicle>> _concereteVehicleImplementations = new()
		{
			{ "Car", () => new Car() },
			{ "Boat", () => new Boat() }
		};
	public IVehicle CreateVehicle(string key)
	{
		return _concereteVehicleImplementations.TryGetValue(key, out Func<IVehicle>? implementation) ?
			implementation() : new Bicycle();
	}
}
