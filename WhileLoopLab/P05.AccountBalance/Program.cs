namespace P05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double total = 0;
            while (command != "NoMoreMoney")
            {
                double number = double.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += number;
                Console.WriteLine($"Increase: {number:f2}");

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
