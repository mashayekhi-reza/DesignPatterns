using ParameterizedFactoryMethod.Structural.Products;

namespace ParameterizedFactoryMethod.Structural.Factory
{
	public interface IFactory
	{
		IProduct CreateProduct(string key);
	}
}
