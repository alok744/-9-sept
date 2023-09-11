using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("it is not a prime number");
            }
            Console.ReadLine();

        }

    }