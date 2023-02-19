using FactoryMethodPattern.Example.ReportPages;

namespace FactoryMethodPattern.Example
{
	public class Resume : IDocument
	{
		private readonly List<IPage> _pages = new();
		public List<IPage> Pages => _pages;

		public void CreatePages()
		{
			_pages.Add(new EducationPage());
			_pages.Add(new SkillsPage());
			_pages.Add(new ExperiencePage());
		}
	}
}
