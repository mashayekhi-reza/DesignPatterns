namespace FactoryMethodPattern.Example
{
	public interface IDocument
	{
		List<IPage> Pages { get; }
		void CreatePages();
    }
}
