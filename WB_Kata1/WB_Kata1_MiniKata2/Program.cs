namespace WB_Kata1_MiniKata2;

class Program
{
    static void Main(string[] args)
    {
            string name ="Arin";
            int health= 100;
            float attackPower = 30.5f;
            bool isParalyzed = true;
            double currencyAmount = 24.75;
            double experience = 250.00;
            string goldCoins = "150.3333333";

            double doubleHealth = health;
            int intAttackPower = (int)attackPower;
            int intExperience = Convert.ToInt32(experience);
            double parseStringNumber = double.Parse(goldCoins);
            bool isParsingName = int.TryParse(name, out int parsedName);
            
            Console.WriteLine($"Health as double (implicit conversion): {doubleHealth}\r\nAttack Power as int (explicit conversion): {intAttackPower}\r\nExperience as int (using Convert): {intExperience}\r\nGold Coins as double (parsed from string): {parseStringNumber}");

            if (isParsingName)
            {
                Console.WriteLine($"Parsing name to integer : {name}");
            }
            else
            {
                Console.WriteLine("Parsing failed: 'invalid' is not a number.");
            }
    }
}