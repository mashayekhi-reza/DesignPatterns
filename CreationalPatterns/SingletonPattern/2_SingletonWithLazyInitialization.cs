namespace SingletonPattern
{
	public class SingletonWithLazyInitialization
	{
		private static SingletonWithLazyInitialization? _instance;
		
		protected SingletonWithLazyInitialization()
		{
		}

		public static SingletonWithLazyInitialization Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new SingletonWithLazyInitialization();
				}
				return _instance;
			}
		}
	}
}
