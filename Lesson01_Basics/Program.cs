namespace Lesson01_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string namePlayer = Console.ReadLine();
            Console.Write("Class: ");
            string classPlayer = Console.ReadLine();
            Console.Write("Level: ");
            double levelPlayer = Convert.ToDouble(Console.ReadLine());
            Console.Write("Health: ");
            double healthPlayer = Convert.ToDouble(Console.ReadLine());

            double maxHealthPlayer = healthPlayer * 1.2d;

            Console.WriteLine($"""

                Name: {namePlayer}
                Class: {classPlayer}
                Level: { levelPlayer}
                Health: {healthPlayer}
                Max health: {maxHealthPlayer}

                """);

            
        }
    }
}
