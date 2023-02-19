namespace FluentBuilderPattern.Structural
{
	public class ConcreteBuilderB : IBuilder
	{
		private readonly Product _product = new();
		public IBuilder CreatePartA()
		{
			_product.AddPart("Part X");
			return this;
		}

		public IBuilder CreatePartB()
		{
			_product.AddPart("Part Y");
			return this;
		}
		public Product Build()
		{
			return _product;
		}
	}
}
