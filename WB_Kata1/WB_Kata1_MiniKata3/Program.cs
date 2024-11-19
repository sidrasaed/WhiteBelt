namespace WB_Kata1_MiniKata3;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int playerLuck = rnd.Next(1, 11);
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
        string answer = Console.ReadLine();
            
        if (answer.ToLower() == "yes")
        {
            Console.WriteLine("Attempting to attack...");
            if (playerLuck > 7)
            {
                Console.WriteLine("Success! Your attack hits the enemy.!");
            }
            else if (playerLuck >5 && playerLuck < 8)

            {
                Console.WriteLine("Your attack barely hit the enemy.!");
            }
            else
            {
                Console.WriteLine("you missed the attack.");
            }
        }
        else
        {
            Console.WriteLine("The player retreated.");
        }


    }
}