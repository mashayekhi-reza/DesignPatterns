namespace FluentBuilderPattern.Structural
{
	public interface IBuilder
	{
		IBuilder CreatePartA();
		IBuilder CreatePartB();
		Product Build();
	}
}
