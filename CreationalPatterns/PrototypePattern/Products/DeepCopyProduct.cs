using Newtonsoft.Json;

namespace PrototypePattern.Products
{
	public class DeepCopyProduct : Product
	{
		public DeepCopyProduct(string name) : base(name)
		{
		}

		public override IProduct Clone()
		{
			var serialized = JsonConvert.SerializeObject(this);
			return JsonConvert.DeserializeObject<DeepCopyProduct>(serialized)!;
		}
	}
}
