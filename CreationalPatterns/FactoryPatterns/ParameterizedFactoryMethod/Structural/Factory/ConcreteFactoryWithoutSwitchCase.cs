using ParameterizedFactoryMethod.Structural.Products;

namespace ParameterizedFactoryMethod.Structural.Factory
{
	public class ConcreteFactoryWithoutSwitchCase : IFactory
	{
		private readonly Dictionary<string, Func<IProduct>> _concereteImplementations = new () 
		{
			{ "A", () => new ConcreteProductA() },
			{ "B", () => new ConcreteProductB() }
		};
		public IProduct CreateProduct(string key)
		{
			return _concereteImplementations.TryGetValue(key, out Func<IProduct>? implementation) ?
				implementation() : new ConcreteProductDefault();
		}
	}
}
