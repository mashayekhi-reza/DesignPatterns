namespace SequentialFluentBuilder.Example
{
	public class BmwBuilder : IVehicleBuilder, IWithBrand, IWithEngine, IWithBody, IBuild
	{
		private readonly Vehicle _vehicle = new();
		public Vehicle Build()
		{
			return _vehicle;
		}

		public IBuild AddBody()
		{
			_vehicle.AddPart("Body", "Bmw Body");
			return this;
		}

		public IWithBody AddEngine()
		{
			_vehicle.AddPart("Engine", "Bmw Engine");
			return this;
		}

		public IWithEngine SetBrand()
		{
			_vehicle.Brand = "Bmw";
			return this;
		}

		public IWithBrand SetType()
		{
			_vehicle.Type = "Car";
			return this;
		}
	}
}