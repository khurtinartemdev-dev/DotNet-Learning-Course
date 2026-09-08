namespace Lesson08_Classes
{
    class Enemy
    {
        public string Type = "";
        public int Health;
        public int BaseDamage;
        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Type} took {amount} damage! Remaining HP: {Health}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy goblin = new Enemy();

            goblin.Type = "Goblin";
            goblin.Health = 50;
            goblin.BaseDamage = 10;

            goblin.TakeDamage(20);

        }
    }
}
