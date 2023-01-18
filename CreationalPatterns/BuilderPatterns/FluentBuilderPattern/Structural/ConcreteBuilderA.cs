namespace FluentBuilderPattern.Structural
{
	public class ConcreteBuilderA : IBuilder
	{
		private readonly Product _product = new();
		public IBuilder CreatePartA()
		{
			_product.AddPart("Part A");
			return this;
		}

		public IBuilder CreatePartB()
		{
			_product.AddPart("Part B");
			return this;
		}
		public Product Build()
		{
			return _product;
		}
	}
}
