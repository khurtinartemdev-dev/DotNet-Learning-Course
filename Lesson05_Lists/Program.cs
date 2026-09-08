namespace Lesson05_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> activeQuests = new List<string>();

            activeQuests.Add("Collect wood");
            activeQuests.Add("Create a sword");
            activeQuests.Add("Defeat the dragon");

            Console.WriteLine(activeQuests.Count);
            foreach (var Quest in activeQuests)
            {
                Console.WriteLine(Quest);
            }

            activeQuests.Remove("Defeat the dragon");

            if(activeQuests.Contains("Defeat the dragon"))
            {
                Console.WriteLine("The quest was not deleted.");
            }
            else
            {
                Console.WriteLine("The quest has been removed");
            }

            Console.WriteLine("\nUpdated Quest Log:");
            foreach (var quest in activeQuests)
            {
                Console.WriteLine(quest);
            }
        }
    }
}
