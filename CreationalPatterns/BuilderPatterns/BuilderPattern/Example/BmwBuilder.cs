namespace BuilderPattern.RealWorldExample
{
	public class BmwBuilder : IVehicleBuilder
	{
		private readonly Vehicle _vehicle = new();
		public void AddBody()
		{
			_vehicle.AddPart("Body", "Bmw Body");
		}

		public void AddEngine()
		{
			_vehicle.AddPart("Engine", "Bmw Engine");
		}

		public void SetBrand()
		{
			_vehicle.Brand = "Bmw";
		}

		public void SetType()
		{
			_vehicle.Type = "Car";
		}

		public Vehicle GetVehicle()
		{
			return _vehicle;
		}
	}
}