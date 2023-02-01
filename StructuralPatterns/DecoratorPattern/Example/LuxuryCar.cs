namespace DecoratorPattern.Example
{
	public class LuxuryCar : ICar
	{
		public double GetCost()
		{
			return 20.00;
		}

		public string GetDescription()
		{
			return GetType().Name;
		}
	}
}