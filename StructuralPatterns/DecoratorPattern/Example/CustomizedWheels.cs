namespace DecoratorPattern.Example
{
	public class CustomizedWheels : CarFacilitator
	{
		public CustomizedWheels(ICar car) : base(car)
		{
		}

		public override double GetCost()
		{
			return base.GetCost() + 1.50;
		}

		public override string GetDescription()
		{
			return $"{base.GetDescription()}, customized wheels added";
		}
	}
}
