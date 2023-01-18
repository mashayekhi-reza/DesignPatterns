namespace SequentialFluentBuilder.Example
{
	public interface IVehicleBuilder
	{
		IWithBrand SetType();
	}

	public interface IWithBrand
	{
		IWithEngine SetBrand();
	}

	public interface IWithEngine
	{
		IWithBody AddEngine();
	}

	public interface IWithBody
	{
		IBuild AddBody();
	}

	public interface IBuild
	{
		Vehicle Build();
	}
}
