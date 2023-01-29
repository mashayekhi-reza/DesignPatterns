namespace AdapterPattern.ObjectAdapterWithInjection
{
	public class AdapterOI : ITargetOI
	{
		private readonly IAdapteeOI _adaptee;

		public AdapterOI(IAdapteeOI adaptee)
		{
			_adaptee = adaptee;
		}

		public string Request()
		{
			return _adaptee.SpecificRequest();
		}
	}
}
