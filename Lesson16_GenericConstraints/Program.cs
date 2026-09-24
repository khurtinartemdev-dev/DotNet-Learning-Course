namespace Lesson16_GenericConstraints
{
    public interface IItem
    {
        string Name { get; }
        int Weight { get; }
    }

    public class HealthPotion : IItem
    {
        public string Name { get; }
        public int Weight { get; }

        public int HealAmount { get; }

        public HealthPotion(string name , int weight, int healAmount)
        {
            this.Name = name;
            this.Weight = weight;
            this.HealAmount = healAmount;
        }
        
    }

    public class Inventory<T> where T : IItem
    {
        List<T> _items = new List<T>();

        public void AddItem(T item) 
        {
            _items.Add(item);
            Console.WriteLine($"Added item: {item.Name} (Weight: {item.Weight})");
        }

        public void GetTotalWeight()
        {
            int totalWeight = 0;
            foreach (var item in _items)
            {
                totalWeight += item.Weight;
            }
            Console.WriteLine($"Total inventory weight: {totalWeight}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory<IItem> inventory = new Inventory<IItem>();

            inventory.AddItem(new HealthPotion("Big", 10, 100));
            inventory.AddItem(new HealthPotion("Small", 2, 20));

            inventory.GetTotalWeight();

        }
    }
}
