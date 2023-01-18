namespace BuilderPattern.Structural
{
	public class ConcreteBuilderB : IBuilder
	{
		private Product _product = new();
		public void CreatePartA()
		{
			_product.AddPart("partX");
		}

		public void CreatePartB()
		{
			_product.AddPart("partY");
		}

		public Product GetProduct()
		{
			return _product;
		}
	}
}
