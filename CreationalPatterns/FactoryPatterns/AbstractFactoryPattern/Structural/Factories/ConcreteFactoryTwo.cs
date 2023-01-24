using AbstractFactoryPattern.Structural.Products;

namespace AbstractFactoryPattern.Structural.Factories
{
	public class ConcreteFactoryTwo : IFactory
	{
		public IProductA CreateProductA()
		{
			return new ConcreteProductATwo();
		}

		public IProductB CreateProductB()
		{
			return new ConcreteProductBTwo();
		}
	}
}
