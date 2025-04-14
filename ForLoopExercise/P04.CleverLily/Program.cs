namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toysCounter = 0;
            double money = 0;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    if (i > 2)
                    {
                        money += (i / 2) * 10 - 1;
                    }
                    else
                    {
                        money += 10 - 1;
                    }
                }
                else
                {
                    toysCounter += 1;
                }
            }
            double toysMoney = toysCounter * toyPrice;
            double totalMoney = money + toysMoney;
            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - totalMoney:f2}");
            }
        }
    }
}
