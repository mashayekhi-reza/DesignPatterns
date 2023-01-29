namespace SingletonPattern
{
	public class SingletonWithEagerInitialization
	{
		private static SingletonWithEagerInitialization _instance = new SingletonWithEagerInitialization();

		protected SingletonWithEagerInitialization()
		{
		}

		public static SingletonWithEagerInitialization Instance => _instance;
	}
}
