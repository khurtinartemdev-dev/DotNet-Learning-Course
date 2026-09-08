namespace Lesson03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int health;
            int enemyHealth = 80;
            int enemyDamage = 15;
            int playerDamage = 20;
            do
            {
                Console.Write("Health: ");
                string inputHealth = Console.ReadLine();
                if (!int.TryParse(inputHealth, out health) || health <= 0)
                {
                    Console.WriteLine("Health was entered incorrectly");
                }
                
            }
            while (health <= 0);

            while (enemyHealth > 0 && health > 0)
            {
                health -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine($"Health Player: {health}");
                Console.WriteLine($"Health Enemy: {enemyHealth}");


            }
            if (enemyHealth <= 0 && health <= 0) 
            {
                Console.WriteLine("Draw!");
            } else if(health <= 0)
            {
                Console.WriteLine("Loser!");
            }
            else
            {
                Console.WriteLine("Winner!");
            }

        }
    }
}
