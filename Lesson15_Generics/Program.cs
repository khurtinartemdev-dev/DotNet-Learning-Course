namespace Lesson15_Generics
{
    public class Storage<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T GetItem(int index) 
        {
            return _items[index];
        }

        public void PrintAll()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage<int> numbers = new Storage<int>();
            Storage<string> strings = new Storage<string>();

            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(10);
            numbers.Add(13);

            strings.Add("One");
            strings.Add("Two");
            strings.Add("Three");

            numbers.PrintAll();
            strings.PrintAll();

        }
    }
}
