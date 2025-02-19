// Actual singleton object implementation

namespace SingletonDemo
{
	internal class EnemyManager
	{
		/// <summary>
		/// One any only one instance of the class
		/// </summary>
		private static EnemyManager _instance = null!;

		/// <summary>
		/// Gets the one and only instance of the class
		/// </summary>
		public static EnemyManager Instance
		{
			get
			{
				// If we don't have one yet, make one!
				if (_instance == null)
					_instance = new EnemyManager();

				// Return the one and only
				return _instance;
			}
		}


		/// <summary>
		/// Private constructor ensure we can't just
		/// make these *anywhere* in our code
		/// </summary>
		private EnemyManager() { }


		public void SpawnEnemy()
		{
			Console.WriteLine("Enemy spawned!");
		}

		public void DestroyEnemy()
		{
			Console.WriteLine("Enemy dead!");
		}
	}
}
