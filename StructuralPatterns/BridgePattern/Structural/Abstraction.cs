namespace BridgePattern.Structural
{
	public abstract class Abstraction
	{
		protected readonly IImplementor _implementor;

		public Abstraction(IImplementor implementor)
		{
			_implementor = implementor;
		}

		public abstract string Operation();
	}
}
