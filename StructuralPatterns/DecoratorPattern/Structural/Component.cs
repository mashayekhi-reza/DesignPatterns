namespace DecoratorPattern.Structural
{
	public class Component : IComponent
	{
		public string Operation()
		{
			return GetType().Name;
		}
	}
}