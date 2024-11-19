namespace WB_ExamKata;

class Program
{
    static void Main(string[] args)
    {
        string player = "Hero";
        string enemy = "Goblin";
        int playerHealth = 130;
        int enemyHealth = 120;
        int attackDamage = 25;
        int healAmount = 40;
        
        Console.WriteLine("Welcome to the RPG Battle!");
        Console.WriteLine($"{player} vs {enemy}\n");

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            if (playerChoice == 1)
            {
                enemyHealth -= attackDamage;
                Console.WriteLine("Hero attacks the Goblin!");
                Console.WriteLine($"Goblin takes {attackDamage} damage.");
                Console.WriteLine("Hero's Health: {0} " , playerHealth);
                Console.WriteLine("Goblin's Health: {0}" , enemyHealth);

            }

            else if (playerChoice == 2)
            {
                Console.WriteLine("Hero chooses to heal");
                playerHealth += healAmount;
                Console.WriteLine($"Hero takes {healAmount} heals.");
                Console.WriteLine("Hero's Health: {0} " , playerHealth);
                Console.WriteLine("Goblin's Health: {0}" , enemyHealth);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose again");
                continue;
            }


            if (enemyHealth <= 0)
            {
                Console.WriteLine($"Congratulations! {player} has defeated the {enemy}!");
                break;
            }

            Console.WriteLine($"{enemy} attacks {player}!");
            playerHealth -= attackDamage;
            Console.WriteLine($"Hero takes {attackDamage} damage.");
            Console.WriteLine("Hero's Health: {0} " , playerHealth);
            Console.WriteLine("Goblin's Health: {0}" , enemyHealth);
            if (playerHealth <= 0)
            {
                Console.WriteLine($"{player} has been defeated by the {enemy}. Game over!");
                break;
            }

            Console.WriteLine();
        }
    }
}