// Chris Cascioli
// 2/19/25
// Example of the singleton design pattern

namespace SingletonDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EnemyManager.Instance.SpawnEnemy();
			EnemyManager.Instance.SpawnEnemy();
			EnemyManager.Instance.SpawnEnemy();

			EnemyManager.Instance.DestroyEnemy();

		}
	}
}
