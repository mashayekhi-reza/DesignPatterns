using ParameterizedFactoryMethod.Structural.Products;

namespace ParameterizedFactoryMethod.Structural.Factory
{
	public class ConcreteFactory : IFactory
	{
		public IProduct CreateProduct(string key)
		{
			return key switch
			{
				"A" => new ConcreteProductA(),
				"B" => new ConcreteProductB(),
				_ => new ConcreteProductDefault()
			};
		}
	}
}
