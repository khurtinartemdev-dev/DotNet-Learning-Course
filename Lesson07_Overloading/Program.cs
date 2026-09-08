namespace Lesson07_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Attack(20);
            Attack(20, "critical");
            Heal(30);
            Heal(50, "Greater Potion");
        }
        static void Attack(int baseDamage)
        {
            Console.WriteLine($"Dealt {baseDamage} damage!");
        }
        static void Attack(int baseDamage, string criticalType)
        {
            if(criticalType.ToLower() == "critical")
            {
                baseDamage *= 2;
                Console.WriteLine($"CRITICAL HIT! Dealt {baseDamage} damage!");

            }
            else
            {
                Attack(baseDamage);
            }
        }
        static void Heal(int amount, string potionName = "Standard Potion")
        {
            Console.WriteLine($"Healed for {amount} HP using {potionName}.");
        }
    }
}
