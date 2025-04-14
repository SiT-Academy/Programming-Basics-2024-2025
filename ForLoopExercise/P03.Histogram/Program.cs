    namespace P03.Histogram
    {
        internal class Program
        {
            /*   static void Main(string[] args)
               {
                   int n = int.Parse(Console.ReadLine());

                   double p1 = 0;
                   double p2 = 0;
                   double p3 = 0;
                   double p4 = 0;
                   double p5 = 0;
                   for (int i = 0; i < n; i++)
                   {
                       int number = int.Parse(Console.ReadLine());

                       if (number < 200)
                       {
                           p1++;
                       }
                       else if (number <= 399)
                       {
                           p2++;
                       }
                       else if (number <= 599)
                       {
                           p3++;
                       }
                       else if (number <= 799)
                       {
                           p4++;
                       }
                       else
                       {
                           p5++;
                       }
                   }

                   Console.WriteLine($"{(p1 / n * 100):f2}%");
                   Console.WriteLine($"{(p2 / n * 100):f2}%");
                   Console.WriteLine($"{(p3 / n * 100):f2}%");
                   Console.WriteLine($"{(p4 / n * 100):f2}%");
                   Console.WriteLine($"{(p5 / n * 100):f2}% ");
               } */

            static void Main(string[] args)
            {
                double n = int.Parse(Console.ReadLine());
                int p1 = 0;
                int p2 = 0;
                int p3 = 0;
                int p4 = 0;
                int p5 = 0;

                int number = 0;
                for (int i = 0; i < n; i++)
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 200)
                    {
                        p1++;
                    }
                    else if (number < 400)
                    {
                        p2++;
                    }
                    else if (number < 600)
                    {
                        p3++;
                    }
                    else if (number < 800)
                    {
                        p4++;
                    }
                    else if (number >= 800)
                    {
                        p5++;
                    }
                }

                double resultP1 = p1 / n * 100;
                double resultP2 = p2 / n * 100;
                double resultP3 = p3 / n * 100;
                double resultP4 = p4 / n * 100;
                double resultP5 = p5 / n * 100;

                Console.WriteLine($"{resultP1:f2}%");
                Console.WriteLine($"{resultP2:f2}%");
                Console.WriteLine($"{resultP3:f2}%");
                Console.WriteLine($"{resultP4:f2}%");
                Console.WriteLine($"{resultP5:f2}%");
            }
        }
    }
