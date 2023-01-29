namespace SequentialFluentBuilder.Example
{
	public class BenzBuilder : IVehicleBuilder, IWithBrand, IWithEngine, IWithBody, IBuild
	{
		private readonly Vehicle _vehicle = new();
		public Vehicle Build()
		{
			return _vehicle;
		}

		public IBuild AddBody()
		{
			_vehicle.AddPart("Body", "Benz Body");
			return this;
		}

		public IWithBody AddEngine()
		{
			_vehicle.AddPart("Engine", "Benz Engine");
			return this;
		}

		public IWithEngine SetBrand()
		{
			_vehicle.Brand = "Benz";
			return this;
		}

		public IWithBrand SetType()
		{
			_vehicle.Type = "Car";
			return this;
		}
	}
}