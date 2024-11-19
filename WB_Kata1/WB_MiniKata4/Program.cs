namespace WB_MiniKata4;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <6; i++)
        {
            Console.WriteLine($"Enemy #{i} spawned!");
        }

        int enemiesSpawned = 0;
        int maxEnemies = 3;

        while (enemiesSpawned < maxEnemies)
        {
           enemiesSpawned++;
           Console.WriteLine($"Enemy #{enemiesSpawned} spawned!");
        }
        
    }
}