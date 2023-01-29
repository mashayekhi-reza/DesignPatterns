namespace AdapterPattern.ClassAdapter
{
	public class AdapterC : AdapteeC, ITargetC
	{
		public string Request()
		{
			return SpecificRequest();
		}
	}
}
