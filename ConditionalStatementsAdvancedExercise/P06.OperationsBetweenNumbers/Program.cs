namespace P06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operatorSymbol = char.Parse(Console.ReadLine());

            double result = 0;
            string evenOrOdd = "";

            if (operatorSymbol == '+')
            {
                result = num1 + num2;
            }
            else if (operatorSymbol == '-')
            {
                result = num1 - num2;
            }
            else if (operatorSymbol == '*')
            {
                result = num1 * num2;
            }

            if (num2 == 0 || num1 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else
            {
                if (operatorSymbol == '/')
                {
                    result = (double)num1 / num2;
                    Console.WriteLine($"{num1} {operatorSymbol} {num2} = {result}");
                }
                else if (operatorSymbol == '%')
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} {operatorSymbol} {num2} = {result}");
                }
            }

            if (operatorSymbol == '+' ||
                operatorSymbol == '-' ||
                operatorSymbol == '*')
            {
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {operatorSymbol} {num2} = {result} - {evenOrOdd}");
            }
            
        }
    }
}
