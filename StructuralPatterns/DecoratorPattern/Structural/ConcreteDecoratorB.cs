namespace DecoratorPattern.Structural
{
	public class ConcreteDecoratorB : Decorator
	{
		public ConcreteDecoratorB(IComponent component) : base(component)
		{
		}

		public override string Operation()
		{
			return $"{base.Operation()}, {GetType().Name}";
		}

		public string AddedBehavior()
		{
			return $"From {GetType().Name}.{System.Reflection.MethodBase.GetCurrentMethod()?.Name}";
		}
	}
}