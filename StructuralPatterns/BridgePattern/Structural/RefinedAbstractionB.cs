namespace BridgePattern.Structural
{
	public class RefinedAbstractionB : Abstraction
	{
		public RefinedAbstractionB(IImplementor implementor) : base(implementor)
		{
		}

		public override string Operation()
		{
			return $"{this.GetType().Name}: {_implementor.OperationImp()}";
		}
	}
}
