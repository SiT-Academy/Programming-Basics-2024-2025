namespace P05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salaray = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook":
                        salaray -= 150;
                        break;
                    case "Instagram":
                        salaray -= 100;
                        break;
                    case "Reddit":
                        salaray -= 50;
                        break;
                }

                if (salaray <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salaray > 0)
            {
                Console.WriteLine(salaray);
            }
        }
    }
}
