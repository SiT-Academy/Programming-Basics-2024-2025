namespace P09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string placeType = Console.ReadLine();
            string rating = Console.ReadLine();

            int nightsToStay = 0;

            if (days > 1)
            {
                nightsToStay = days - 1;
            }
            else
            {
                // 0 или 1
                nightsToStay = days;
            }

            decimal totalSum = 0;
            decimal discount = 1;
            if (placeType == "room for one person")
            {
                totalSum = nightsToStay * 18;
            }
            else if (placeType == "apartment")
            {
                totalSum = nightsToStay * 25;
                if (nightsToStay < 10)
                {
                    discount = 0.3m;
                }
                else if (nightsToStay <= 15)
                {
                    discount = 0.35m;
                }
                else if (nightsToStay > 15)
                {
                    discount = 0.5m;
                }
            }
            else if (placeType == "president apartment")
            {
                totalSum = nightsToStay * 35;
                if (nightsToStay < 10)
                {
                    discount = 0.1m;
                }
                else if (nightsToStay <= 15)
                {
                    discount = 0.15m;
                }
                else if (nightsToStay > 15)
                {
                    discount = 0.20m;
                }
            }

            decimal discountFromTheTotalSum = totalSum * discount;
            decimal totalSumWihDiscount = totalSum - discountFromTheTotalSum;

            decimal totalSumWihDiscountAndRating = 0;
            if (rating == "positive")
            {
                decimal tip = 0;
                if (totalSumWihDiscount == 0)
                {
                    tip = totalSum * 0.25m;
                    totalSumWihDiscountAndRating = totalSum + tip;
                }
                else
                {
                    tip = totalSumWihDiscount * 0.25m;
                    totalSumWihDiscountAndRating = totalSumWihDiscount + tip;
                }
            }
            else
            {
                decimal discountRating = totalSumWihDiscount * 0.1m;
                totalSumWihDiscountAndRating = totalSumWihDiscount - discountRating;
            }

            Console.WriteLine($"{totalSumWihDiscountAndRating:f2}");
        }
    }
}
