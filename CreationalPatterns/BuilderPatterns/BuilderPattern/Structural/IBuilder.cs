namespace BuilderPattern.Structural
{
	public interface IBuilder
	{
		void CreatePartA();
		void CreatePartB();
		Product GetProduct();
	}
}