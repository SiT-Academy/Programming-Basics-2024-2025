namespace P08.OnTimeForTeExam
{
    internal class Program
    {
        //TODO
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMins = int.Parse(Console.ReadLine());

            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMins = int.Parse(Console.ReadLine());

            if (examMins - 30 < 0 && arriveHour == examHour - 1)
            {
                // 9:00 8:30 до 9:00
                // 1h = 60min 
                // 
                //         начало 8:30                       края 9:00
                if (arriveMins <= 59 && arriveMins >= )
                {
                        
                }
            }
            // 9:30    9:00 до 9:30

        }
    }
}
