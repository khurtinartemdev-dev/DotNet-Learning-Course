namespace Lesson11_Inheritance
{
    class Entity
    {
        public string Name { get; set; }
        public int Health { get; protected set; }

        public Entity(string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }

        public void TakeDamage(int amount)
        {
            this.Health = Math.Max(0, this.Health - amount);
            Console.WriteLine($"{this.Name} received damage: {amount} Your health: {this.Health}");
        }
    }

    class Hero : Entity
    {
        public string ClassName { get; set; }

        public Hero(string name, int health, string className) : base(name, health)
        {
            this.ClassName = className;
        }

        public void UseAbility()
        {
            Console.WriteLine($"{this.Name} uses class ability as {this.ClassName}!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero knight = new Hero("Arthur", 120, "Paladin");
            knight.TakeDamage(30);
            knight.UseAbility();
        }
    }
}
