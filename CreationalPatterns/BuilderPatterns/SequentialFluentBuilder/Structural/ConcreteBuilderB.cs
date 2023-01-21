namespace SequentialFluentBuilder.Structural
{
	public class ConcreteBuilderB : IBuilder, IWithPartB, IBuild
	{
		private readonly Product _product = new();

		public IWithPartB CreatePartA()
		{
			_product.AddPart("PartX");
			return this;
		}

		public IBuild CreatePartB()
		{
			_product.AddPart("PartY");
			return this;
		}

		public Product Build()
		{
			return _product;
		}
	}
}


