namespace FacadePattern.Structural
{
	public class FirstSubSystem : IFirstSubSystem
	{
		public string MethodA()
		{
			return $"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}";
		}

		public string MethodB()
		{
			return $"{GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}";
		}
	}
}
