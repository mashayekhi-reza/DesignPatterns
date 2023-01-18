namespace FluentBuilderPattern.Structural
{
	public class Director
	{
		public void Contruct(IBuilder builder)
		{
			builder
				.CreatePartA()
				.CreatePartB();
		}
	}
}
