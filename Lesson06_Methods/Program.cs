namespace Lesson06_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHeader("COMBAT LOG");

            int totalDamage = CalculateFinalDamage(50, 20);
            Console.WriteLine($"Total damage: {totalDamage}");

            if (IsPlayerAlive(100 - totalDamage)) 
            {
                Console.WriteLine("The player is alive");
            }
            else 
            {
                Console.WriteLine("The player died");
            }  

        }
        static void PrintHeader(string title)
        {
            Console.WriteLine($"=== {title} ===");
        }
        static int CalculateFinalDamage(int baseDamage, int armor)
        {
            return (baseDamage <= armor) ? 0 : baseDamage - armor;
        }
        static bool IsPlayerAlive(int health) 
        { 
            return health > 0;
        }
        

    }
}
