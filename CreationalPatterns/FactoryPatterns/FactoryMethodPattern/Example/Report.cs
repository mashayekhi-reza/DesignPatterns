using FactoryMethodPattern.Example.ResumePages;

namespace FactoryMethodPattern.Example
{
	public class Report : IDocument
	{
		private readonly List<IPage> _pages = new();
		public List<IPage> Pages => _pages;

		public void CreatePages()
		{
			_pages.Add(new IntroductionPage());
			_pages.Add(new BodyPage());
			_pages.Add(new ConclusionPage());
		}
	}
}
