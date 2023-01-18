namespace SequentialFluentBuilder.Structural
{
	public class ConcreteBuilderA : IBuilder, IWithPartB, IBuild
	{
		private readonly Product _product = new();

		public IWithPartB CreatePartA()
		{
			_product.AddPart("PartA");
			return this;
		}

		public IBuild CreatePartB()
		{
			_product.AddPart("PartB");
			return this;
		}

		public Product Build()
		{
			return _product;
		}
	}
}


