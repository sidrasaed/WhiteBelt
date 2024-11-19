namespace WB_Kata1_MiniKata1;

class Program
{
    static void Main(string[] args)
    {
        string name ="Arin";
        int healthPoints= 100;
        float attackPower = 15.5f;
        bool isParalyzed = true;
        double currencyAmount = 24.75;
            
        Console.WriteLine($"Character Name: {name}\r\nHealth Points: {healthPoints}\r\nAttack Power: {attackPower}\r\nIs Paralyzed: {isParalyzed}\r\nCurrency: {currencyAmount}");
    }
}