using AbstractFactoryPattern.Example.VehiclePartsFactories;

namespace AbstractFactoryPattern.Example
{
	public class VehicleCreator
	{
		private IVehiclePartsFactory _vehiclePartsFactory;

		public void SetVehiclePartsFactory(IVehiclePartsFactory vehiclePartsFactory)
		{
			_vehiclePartsFactory = vehiclePartsFactory;
		}

		public string AssembleVehicle()
		{
			var body = _vehiclePartsFactory.CreateBody();
			var engine = _vehiclePartsFactory.CreateEngine();

			return $"{engine.GetType().Name} attached in {body.GetType().Name}";
		}
	}
}
