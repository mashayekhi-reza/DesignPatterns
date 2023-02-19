namespace FluentBuilderPattern.Example
{
	public interface IVehicleBuilder
	{
		IVehicleBuilder SetType();
		IVehicleBuilder SetBrand();
		IVehicleBuilder AddEngine();
		IVehicleBuilder AddBody();
		Vehicle Build();
	}
}
