namespace BuilderPattern.RealWorldExample
{
	public class BenzBuilder : IVehicleBuilder
	{
		private readonly Vehicle _vehicle = new();
		public void AddBody()
		{
			_vehicle.AddPart("Body", "Benz Body");
		}

		public void AddEngine()
		{
			_vehicle.AddPart("Engine", "Benz Engine");
		}

		public void SetBrand()
		{
			_vehicle.Brand = "Benz";
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