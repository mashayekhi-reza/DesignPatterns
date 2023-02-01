namespace DecoratorPattern.Example
{
	public class EconomyCar : ICar
	{
		public double GetCost()
		{
			return 10.00;
		}

		public string GetDescription()
		{
			return GetType().Name;
		}
	}
}