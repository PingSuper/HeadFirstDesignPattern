using System;
namespace SingletonPattern
{
	public class Singleton
	{
		// Private Constructor
		private Singleton()
		{
		}

		private static Singleton uniqueInstance;

        public static Singleton getInstance()
		{
			if(uniqueInstance == null) {
				uniqueInstance = new Singleton();
			}
			return uniqueInstance;
		}

		// other methods
    }
}

