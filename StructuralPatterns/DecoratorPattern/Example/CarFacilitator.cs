namespace DecoratorPattern.Example
{
	public abstract class CarFacilitator : ICar
	{
		protected readonly ICar _car;

		public CarFacilitator(ICar car)
		{
			_car = car;
		}

		public virtual double GetCost()
		{
			return _car.GetCost();
		}

		public virtual string GetDescription()
		{
			return _car.GetDescription();
		}
	}
}
