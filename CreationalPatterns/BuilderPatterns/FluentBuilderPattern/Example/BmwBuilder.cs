namespace FluentBuilderPattern.Example
{
	public class BmwBuilder : IVehicleBuilder
	{
		private readonly Vehicle _vehicle = new();
		public IVehicleBuilder AddBody()
		{
			_vehicle.AddPart("Body", "Bmw Body");
			return this;
		}

		public IVehicleBuilder AddEngine()
		{
			_vehicle.AddPart("Engine", "Bmw Engine");
			return this;
		}

		public IVehicleBuilder SetBrand()
		{
			_vehicle.Brand = "Bmw";
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