namespace BuilderPattern.Structural
{
	public class ConcreteBuilderA : IBuilder
	{
		private Product _product = new();
		public void CreatePartA()
		{
			_product.AddPart("partA");
		}

		public void CreatePartB()
		{
			_product.AddPart("partB");
		}

		public Product GetProduct()
		{
			return _product;
		}
	}
}
