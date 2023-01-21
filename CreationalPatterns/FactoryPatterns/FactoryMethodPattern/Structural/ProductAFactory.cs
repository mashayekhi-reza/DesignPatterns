namespace FactoryMethodPattern.Structural
{
	public class ProductAFactory : IProductFactory
	{
		public IProduct CreateProduct()
		{
			return new ConcreteProductA();
		}
	}
}
