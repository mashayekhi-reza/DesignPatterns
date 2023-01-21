namespace FluentBuilderPattern.Example
{
	public class BenzBuilder : IVehicleBuilder
	{
		private readonly Vehicle _vehicle = new();
		public IVehicleBuilder AddBody()
		{
			_vehicle.AddPart("Body", "Benz Body");
			return this;
		}

		public IVehicleBuilder AddEngine()
		{
			_vehicle.AddPart("Engine", "Benz Engine");
			return this;
		}

		public IVehicleBuilder SetBrand()
		{
			_vehicle.Brand = "Benz";
			return this;
		}

		public IVehicleBuilder SetType()
		{
			_vehicle.Type = "Car";
			return this;
		}

		public Vehicle Build()
		{
			return _vehicle;
		}
	}
}