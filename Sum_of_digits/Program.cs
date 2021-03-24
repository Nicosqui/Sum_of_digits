using System;

namespace Sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de los digitos de " + number + " es: " + SumDigits(number));
        }

        static int SumDigits(int n)
        {
            //base case:
            if (n < 10)
            {
                return n;
            }
            else
            {
                return (n % 10) + SumDigits(n / 10);
            }
        }
    }
}
