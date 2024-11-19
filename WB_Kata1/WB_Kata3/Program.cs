namespace WB_Kata3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You find a mysterious treasure chest! What will you do?");
        Console.WriteLine("1. Open the chest");
        Console.WriteLine("2. Ignore the chest");
        Console.WriteLine("3. Leave the area");
        int playerChoice = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int playerLuck = random.Next(1,11);    

        if (playerChoice == 1)
        {
            if (playerLuck > 7)
            {
                Console.WriteLine("Success! The chest contains a rare gem.");
            }
            else if (playerLuck < 7 & (playerLuck >= 5))
            {
                Console.WriteLine("Success! The chest contains gold.");
            }
            else
            {
                Console.WriteLine("Success! The chest was trapped.");
            }
        }
        else if (playerChoice == 2)
        {
            Console.WriteLine("You choose to ignore the chest.");
        }
        else if (playerChoice == 3)
        {
            Console.WriteLine("You choose to leave the area.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}