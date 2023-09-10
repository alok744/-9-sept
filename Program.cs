using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 153;
            int rem;
            int cube;
            int result = 0;
            int temp = num;

            while (num != 0)
            {
                rem = num % 10;
                cube = rem * rem * rem;
                result = result + cube;
                num = num / 10;
            }
            num = temp;
            if (num==result)
            {
                Console.Write("number is armstrong");

            }
            else
            {
                Console.Write("number is not armstrng");
            }
            Console.ReadLine();
        }
    }
}
