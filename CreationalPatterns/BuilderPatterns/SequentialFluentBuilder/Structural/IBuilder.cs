namespace SequentialFluentBuilder.Structural
{

    public interface IBuilder
    {
        IWithPartB CreatePartA();
    }

	public interface IWithPartB
	{
		IBuild CreatePartB();
	}

	public interface IBuild
	{
		Product Build();
	}
}