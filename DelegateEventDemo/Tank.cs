// Chris Cascioli
// 1/22/25
// Example of a class with an event

namespace DelegateEventDemo
{
	internal class Tank
	{
		// We need an event that can hold (usually) external methods
		public event LowHealthDelegate OnLowHealth;

		private int health;

		/// <summary>
		/// Makes a tank w/ 100 health
		/// </summary>
		public Tank()
		{
			health = 100;
		}

		/// <summary>
		/// Reduces tank's health and potentially 
		/// trigger a "low health" event
		/// </summary>
		/// <param name="amount">Incoming damage</param>
		public void TakeDamage(int amount)
		{
            Console.WriteLine("Ouch!");

			health -= amount;

			// We must explicitly check for a "null event",
			// or we get a crash when there are no subscribers
			if (health < 20 && OnLowHealth != null)
			{
				// Notify the rest of the program
				OnLowHealth("Dyin' over here, need heals!", health);
			}
		}
	}
}
