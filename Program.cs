using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            Console.Write("enter the number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the number2");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the symbol(/,*,+,-)");
            string symbol=Console.ReadLine();

            switch (symbol)

            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Addition"+res);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Subtraction" +res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Multiplication" +res);
                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine("division" +res);
                    break;

                default:
                    Console.WriteLine("worng input:");
                    break;


            }
            Console.ReadLine();
        }
    }
}
