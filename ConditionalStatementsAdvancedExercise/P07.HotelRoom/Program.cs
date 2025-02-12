namespace P07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            decimal studioTotalPrice = 0;
            decimal apartmentTotalPrice = 0;

            decimal discountPercent = 0;
            if (month == "May" || month == "October")
            {
                studioTotalPrice = nightsCount * 50;
                apartmentTotalPrice = nightsCount * 65;
                if (nightsCount > 7 && nightsCount <= 14)
                {
                    discountPercent = 0.05m;
                                                //   250лв - 12.5 = 237.5
                    studioTotalPrice = studioTotalPrice - studioTotalPrice * discountPercent;
                }
                else if (nightsCount > 14)
                {
                    discountPercent = 0.3m;

                    studioTotalPrice = studioTotalPrice - studioTotalPrice * discountPercent;
                }

            }
            else if (month == "June" || month == "September")
            {
                studioTotalPrice = nightsCount * 75.20m;
                apartmentTotalPrice = nightsCount * 68.70m;
                if (nightsCount > 14)
                {
                    discountPercent = 0.2m;
                    studioTotalPrice = studioTotalPrice - studioTotalPrice * discountPercent;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioTotalPrice = nightsCount * 76;
                apartmentTotalPrice = nightsCount * 77;
            }

            if (nightsCount > 14)
            {
                discountPercent = 0.1m;

                apartmentTotalPrice = apartmentTotalPrice - apartmentTotalPrice * discountPercent;
            }

            Console.WriteLine($"Apartment: {apartmentTotalPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioTotalPrice:f2} lv");
        }
    }
}
