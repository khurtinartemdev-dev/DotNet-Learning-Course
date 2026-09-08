namespace Lesson04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inventory = { "Iron Sword", "Health Potion", "Wooden Shield", "Magic Ring" };

            foreach (var item in inventory)
            { 
                Console.WriteLine(item);
            }

            int[] damages = { 15, 25, 10, 30, 5 };
            int sumDamage = 0;
            foreach (var damage in damages)
            {
                sumDamage += damage;
            }
            double averageDamage = (double)sumDamage/damages.Length;

            Console.WriteLine($"Total damage: {sumDamage}");
            Console.WriteLine($"Average damage: {averageDamage}");

        }
    }
}
