using System.Data;

namespace Lesson17_Exceptions
{
    public class ItemBrokenException : Exception
    {
        public string ItemName { get; }

        public ItemBrokenException(string message, string itemName)
            : base(message)
        {
            ItemName = itemName;
        }
    }
    public class Equipment
    {
        public string Name { get; set; }
        public int Durability { get; private set; }

        public Equipment(string name, int durability)
        {
            this.Name = name;
            this.Durability = durability;
        }

        public void Use(int durabilityLoss)
        {
            
            if (durabilityLoss <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(durabilityLoss), "Durability loss must be positive.");
            }
            if (durabilityLoss > this.Durability)
            {
                this.Durability = 0; 
                throw new ItemBrokenException($"Item '{Name}' broke!", Name);
            }

            
            this.Durability -= durabilityLoss;
            Console.WriteLine($"[Success] {Name} used. Remaining durability: {this.Durability}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Equipment sword = new Equipment("Iron Sword", 20);

            int[] testDamages = { 5, -10, 30 };

            foreach (int damage in testDamages)
            {
                try
                {
                    Console.WriteLine($"\n[Attempt] Trying to use item with damage: {damage}");

                    sword.Use(damage);
                }
                catch (ItemBrokenException ex)
                {
                    Console.WriteLine($"[Broken Error] {ex.Message} (Item: {ex.ItemName})");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"[Argument Error] {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[General Error] {ex.Message}");
                }
                finally
                {
                    Console.WriteLine($"[Log] Remaining durability: {sword.Durability}");
                }
            }
        }
    }
}
