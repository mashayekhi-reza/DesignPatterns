using AbstractFactoryPattern.Structural.Products;

namespace AbstractFactoryPattern.Structural.Factories
{
	public interface IFactory
	{
		IProductA CreateProductA();
		IProductB CreateProductB();
	}
}
