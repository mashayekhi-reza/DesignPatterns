namespace BridgePattern.Structural
{
	public class ConcreteImplementorB : IImplementor
	{
		public string OperationImp()
		{
			return $"{this.GetType().Name} {System.Reflection.MethodBase.GetCurrentMethod()?.Name}";
		}
	}
}
