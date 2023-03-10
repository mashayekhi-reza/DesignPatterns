namespace DecoratorPattern.Structural
{
	public abstract class Decorator : IComponent
	{
		protected readonly IComponent _component;

		public Decorator(IComponent component)
		{
			_component = component;
		}


		public virtual string Operation()
		{
			return _component.Operation();
		}
	}
}