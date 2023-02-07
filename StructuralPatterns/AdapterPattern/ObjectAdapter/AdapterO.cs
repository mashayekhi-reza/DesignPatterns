namespace AdapterPattern.ObjectAdapter
{
	public class AdapterO : ITargetO
	{
		private readonly AdapteeO _adaptee = new();

		public string Request()
		{
			return _adaptee.SpecificRequest();
		}
	}
}
