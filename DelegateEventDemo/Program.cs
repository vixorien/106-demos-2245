// Chris Cascioli
// 1/22/25
// Demo of delegates and events

namespace DelegateEventDemo
{
	// Delegates are often declared outside of classes
	// so they are available through the entire namespace
	// - This is essentially a data type we can use later
	public delegate void LowHealthDelegate(string message, int health);

	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a tank and hook up it's event
			// to our fancy function below
			Tank t = new Tank();
			t.OnLowHealth += OhNoSomeoneIsLowOnHealth;

			t.TakeDamage(5);
			t.TakeDamage(20);
			t.TakeDamage(3);
			t.TakeDamage(40);
			t.TakeDamage(15);
		}

		static void OhNoSomeoneIsLowOnHealth(string message, int health)
		{
            Console.WriteLine("Incoming message: " + message);
            Console.WriteLine("Remaining health: " + health);
		}
	}
}
