namespace BuilderPattern.RealWorldExample
{
	public interface IVehicleBuilder
	{
		void SetType();
		void SetBrand();
		void AddEngine();
		void AddBody();
		Vehicle GetVehicle();
	}
}
