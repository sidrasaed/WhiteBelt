namespace WB_Kata4;

class Program
{
    static void Main(string[] args)
    {
        int wave = 0;
        int totalWaves = 3;
        int enemy = 0;
        int enemiesPerWave = 4;

        for (wave = 1; wave <= totalWaves; wave++)
        {
            Console.WriteLine($"Wave {wave} is starting!");
            for (enemy = 1; enemy <= enemiesPerWave; enemy++)
            {
                Console.WriteLine($"    Enemy #{enemy} has spawned.");
            }
            Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...");
            Thread.Sleep(1000);
            Console.WriteLine("");
            
        }

    }
}