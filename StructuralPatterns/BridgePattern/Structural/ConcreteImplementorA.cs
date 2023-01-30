namespace BridgePattern.Structural
{
	public class ConcreteImplementorA : IImplementor
	{
		public string OperationImp()
		{
			return $"{this.GetType().Name} {System.Reflection.MethodBase.GetCurrentMethod()?.Name}";
		}
	}
}
