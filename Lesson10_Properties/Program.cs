namespace Lesson10_Properties
{
    internal class Program
    {
        class Armor
        {
            public string Name { get; set; }
            public int Defense {  get; private set; }
            public int Durability 
            {
                get => _durability; 
                set { _durability = value < 0 ? 0 : value; }
            }

            private int _durability;


            public Armor(string name, int defense, int durability)
            {
                this.Name = name;
                this.Defense = defense;
                this.Durability = durability;
            }

            public void TakeWear(int amount)
            {
                this.Durability -= amount;
            }


        }
        static void Main(string[] args)
        {

            Armor shield = new Armor("Iron Shield", 15, 50);

            Console.WriteLine($"Durability: {shield.Durability}");

            shield.TakeWear(100);

            Console.WriteLine($"Durability: {shield.Durability}");

        }
    }
}
