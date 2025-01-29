namespace P05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            double budgetToSpend = 0;
            string destination = "";
            string placeToSleep = "";
            if (budget <= 100)
            {
                // Bulgaria
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budgetToSpend = budget * 0.3;
                    placeToSleep = "Camp";
                }
                else if (season == "winter")
                {
                    budgetToSpend = budget * 0.7;
                    placeToSleep = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                //Balkans
                destination = "Balkans";
                if (season == "summer")
                {
                    budgetToSpend = budget * 0.4;
                    placeToSleep = "Camp";
                }
                else if (season == "winter")
                {
                    budgetToSpend = budget * 0.8;
                    placeToSleep = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                // Europe
                destination = "Europe";
                budgetToSpend = budget * 0.9;
                placeToSleep = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToSleep} - {budgetToSpend:f2}");
        }
    }
}
