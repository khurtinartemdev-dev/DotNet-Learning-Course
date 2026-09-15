namespace Lesson14_Interfaces
{
    public interface IInteractable
    {
        void Interact();
    }
    public interface IDamageable
    {
        int Health { get; }
        void TakeDamage(int amount);

    }
    public class ExplosionBarrel: IInteractable , IDamageable
    {

        public int Health { get; private set; } = 50;
        public void Interact ()
        {
            Console.WriteLine("You kick the barrel. It rolls slightly and rattles loudly.");
        }
        public void TakeDamage(int amount)
        {
            this.Health -= amount;
            if (this.Health <= 0)
            {
                Console.WriteLine("BOOM! The barrel exploded, dealing area-of-effect fire damage!");
            }
            else
            {
                Console.WriteLine($"The barrel took {amount} damage! Remaining stability: {Health} HP.");
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Direct Barrel Actions ===");

            ExplosionBarrel barrel = new ExplosionBarrel();

            Console.WriteLine("\n=== Testing IInteractable Interface ===");
            IInteractable interactable = barrel;
            interactable.Interact();

            Console.WriteLine("\n=== Testing IDamageable Interface ===");
            IDamageable damageable = barrel;
            damageable.TakeDamage(10);


        }
    }
}
