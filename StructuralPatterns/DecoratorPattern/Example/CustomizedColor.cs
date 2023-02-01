namespace DecoratorPattern.Example
{
	public class CustomizedColor : CarFacilitator
	{
		public CustomizedColor(ICar car) : base(car)
		{
		}

		public override double GetCost()
		{
			return base.GetCost() + 2.00;
		}

		public override string GetDescription()
		{
			return $"{base.GetDescription()}, customized color added";
		}
	}
}
