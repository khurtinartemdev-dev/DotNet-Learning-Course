namespace Lesson13_AbstractClasses
{
    abstract class Spell
    {
        public string Name { get; set; }
        public int ManaCost {  get; protected set; }
        
        public Spell(string name, int manaCost)
        {
            this.Name = name;
            this.ManaCost = manaCost;
        }

        public abstract void Cast();

        public void DisplayInfo()
        {
            Console.WriteLine($"Spell: {this.Name} (Cost: {this.ManaCost} MP)");
        }


    }
    class Fireball : Spell
    {
        public int Damage { get; set; }

        public Fireball(string name, int manaCost, int damage) : base(name, manaCost)
        {
            this.Damage = damage;
        }

        public override void Cast()
        {
            Console.WriteLine($"Casting {this.Name}! Deals {this.Damage} fire damage.");
        }
    }

    class HealSpell : Spell
    {
        public int HealAmount { get; set; }

        public HealSpell(string name, int manaCost, int healAmount) : base(name, manaCost)
        {
            this.HealAmount = healAmount;
        }

        public override void Cast()
        {
            Console.WriteLine($"Casting {this.Name}! Restores {this.HealAmount} HP.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Spell> spellbook = new List<Spell>
            {
                new Fireball("Fireball", 15, 40),
                new HealSpell("Great Heal", 20, 50)
            };

            foreach (Spell spell in spellbook) 
            {
                spell.DisplayInfo();
                spell.Cast();
            }
        }
    }
}
