namespace WB_Kata1;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Welcome, brave adventurer! What is your name?");
        string name= Console.ReadLine();
        Console.WriteLine("Greetings, {0} Your journey begins now...", name);
        Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
        int score = int.Parse(Console.ReadLine());
        if (score >= 7)
        {
            Console.WriteLine("Fantastic! You seem ready to take on any challenge!");
        }
        else
        {
            Console.WriteLine("Its okay to feel less motivated some days,but tomorrow will be better. No worries.. :) ");
        }
    }
    
}