namespace FactoryMethodPattern.Structural
{
	public class ProductBFactory : IProductFactory
	{
		public IProduct CreateProduct()
		{
			return new ConcreteProductB();
		}
	}
}
