namespace P04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double numberOfPower = Math.Pow(2, i);
                Console.WriteLine(numberOfPower);
            }
        }
    }
}
