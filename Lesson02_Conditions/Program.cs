namespace Lesson02_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Class: ");
            string classCharacter = Console.ReadLine();

            Console.Write("Level: ");
            int levelCharacter = Convert.ToInt32(Console.ReadLine());

            int damageCharacter = classCharacter.ToLower() switch
            {
                "warrior" => 15,
                "mage" => 25,
                "rogue" => 20,
                _ => 10

            };

            if (levelCharacter >= 10 && classCharacter.ToLower() == "mage")
            {
                damageCharacter += 10;
                Console.WriteLine("Bonus activated: Magic Storm (+10 damage)!");
            }
            ;


            Console.WriteLine($"Class: {classCharacter}");
            Console.WriteLine($"Level: {levelCharacter}");
            Console.WriteLine($"Total Damage: {damageCharacter}");


            if (levelCharacter >= 5)
            {
                Console.WriteLine("Status: You are ready for battle!");
            }
            else
            {
                Console.WriteLine("Status: You are too weak for the arena!");
            }






        }
    }
}