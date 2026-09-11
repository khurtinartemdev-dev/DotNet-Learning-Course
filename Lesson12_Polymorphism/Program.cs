namespace Lesson12_Polymorphism
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

        public virtual void Attack()
        {
            Console.WriteLine($"{this.Name} performs a basic attack!");
        }
    }

    class Monster : Entity 
    {
        public int BaseDamage {  get; set; }

        public Monster(string name, int health, int baseDamage) : base(name, health) 
        { 
            this.BaseDamage = baseDamage;
        }

        public override void Attack()
        {
            Console.WriteLine($"{this.Name} bites savagely for {this.BaseDamage} damage!");
        }



    }

    class Mage : Entity
    {
        public int Mana { get; set; }

        public Mage(string name, int health, int mana) : base(name, health)
        {

           this.Mana = mana;

        }

        public override void Attack()
        {
            if (this.Mana >= 10 ) 
            { 
                this.Mana -= 10;

                Console.WriteLine($"{this.Name} casts a Fireball! Remaining mana: {this.Mana}");
            }
            else 
            {
                base.Attack();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entity> squad = new List<Entity>
            {
                new Entity("Dummy", 50),
                new Monster("Goblin", 30, 12),
                new Mage("Gandalf", 80, 15)
            };

            foreach (Entity entity in squad) 
            { 
                entity.Attack();
            }

        }
    }
}
