using AbstractFactoryPattern.Structural.Products;

namespace AbstractFactoryPattern.Structural.Factories
{
	public class ConcreteFactoryOne : IFactory
	{
		public IProductA CreateProductA()
		{
			return new ConcreteProductAOne();
		}

		public IProductB CreateProductB()
		{
			return new ConcreteProductBOne();
		}
	}
}
