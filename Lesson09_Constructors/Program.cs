namespace Lesson09_Constructors
{
    class Weapon
    {
        public string Name;
        public int Damage;
        public int Durability;

        public Weapon(string name, int damage, int durability)
        {
            this.Name = name;
            this.Damage = damage;
            this.Durability = durability;
        }
        public Weapon(string name, int damage) : this(name, damage, 100)
        {

        }
        

        public void ShowInfo() 
        {
            Console.WriteLine($"Weapon: {Name} | Damage: {Damage} | Durability: {Durability}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon("Iron Sword", 25, 80);
            Weapon bow = new Weapon("Wooden Bow", 15);
            
            sword.ShowInfo();
            bow.ShowInfo();

        }
    }
}
