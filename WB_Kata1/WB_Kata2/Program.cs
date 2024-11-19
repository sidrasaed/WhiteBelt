namespace WB_Kata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Lira";
        int level = 5;
        float healthPoints = 75f;
        double experiencePoints = 102.75;
        bool hasMagicAbility = true;
        char rank = 'A';
        double nextLevelThreshold = 150;
        double pointsToNextLevel = nextLevelThreshold - experiencePoints;
        
        Console.WriteLine("Character Name: {0}", name);
        Console.WriteLine("Level: {0}", level);
        Console.WriteLine("Health Points: {0}", healthPoints);
        Console.WriteLine("Experience Points: {0}", experiencePoints);
        Console.WriteLine("Magic Ability: {0}", hasMagicAbility);
        Console.WriteLine("Rank: {0}", rank);
        Console.WriteLine("points need to reach next level  {0}", pointsToNextLevel);

    }
}