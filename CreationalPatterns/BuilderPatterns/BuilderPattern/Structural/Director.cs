namespace BuilderPattern.Structural
{
	public class Director
	{
		public void Contruct(IBuilder builder)
		{
			builder.CreatePartA();
			builder.CreatePartB();
		}
	}
}
