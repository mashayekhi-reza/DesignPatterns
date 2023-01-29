using ParameterizedFactoryMethod.Example.Vehicles;

namespace ParameterizedFactoryMethod.Example.Factory
{
	public class VehicleFactory : IVehicleFactory
	{
		public IVehicle CreateVehicle(string key)
		{
			return key switch
			{
				"Car" => new Car(),
				"Boat" => new Boat(),
				"Bicycle" => new Bicycle()
			};
		}
	}
}
