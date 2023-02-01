namespace DecoratorPattern.Structural
{
	public class ConcreteDecoratorA : Decorator
	{
		public ConcreteDecoratorA(IComponent component) : base(component)
		{
		}

		public override string Operation()
		{
			return $"{base.Operation()}, {GetType().Name}";
		}
	}
}