namespace FacadePattern.Structural
{
	public class Facade
	{
		private readonly IFirstSubSystem _firstSubSystem;
		private readonly ISecondSubSystem _secondSubSystem;

		public Facade(IFirstSubSystem firstSubSystem, 
			ISecondSubSystem secondSubSystem)
		{
			_firstSubSystem = firstSubSystem;
			_secondSubSystem = secondSubSystem;
		}

		public string FirstFacadeMethod()
		{
			return $"{_firstSubSystem.MethodA()}, {_secondSubSystem.MethodB()}";
		}

		public string SecondFacadeMethod()
		{
			return $"{_secondSubSystem.MethodA()}, {_firstSubSystem.MethodB()}";

		}
	}
}
