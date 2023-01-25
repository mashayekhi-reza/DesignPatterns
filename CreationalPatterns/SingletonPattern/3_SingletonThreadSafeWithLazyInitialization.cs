namespace SingletonPattern
{
	public class SingletonThreadSafeWithLazyInitialization
	{
		private static readonly Lazy<SingletonThreadSafeWithLazyInitialization> _instance
			= new(() => new SingletonThreadSafeWithLazyInitialization());

		protected SingletonThreadSafeWithLazyInitialization()
		{
		}

		public static SingletonThreadSafeWithLazyInitialization Instance => _instance.Value;
	}
}
