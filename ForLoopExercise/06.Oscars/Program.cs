namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            bool isNominated = false;

            for (int i = 0; i < n; i++)
            {
                string gradingPersonName = Console.ReadLine();
                double gradingPersonPoints = double.Parse(Console.ReadLine());

                int nameSymbols = gradingPersonName.Count();
                double result = nameSymbols * gradingPersonPoints / 2;

                points += result;
                if (points >= 1250.5)
                {
                    isNominated = true;
                    break;
                }
            }

            if (isNominated)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points} more!");
            }
        }
    }
}
