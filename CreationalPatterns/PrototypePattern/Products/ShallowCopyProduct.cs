namespace PrototypePattern.Products
{
	public class ShallowCopyProduct : Product
	{
		public ShallowCopyProduct(string name) : base(name)
		{
		}

		public override IProduct Clone()
		{
			return (IProduct)MemberwiseClone();
		}
	}
}
