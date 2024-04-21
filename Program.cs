using System;
namespace fabonacci_series
{
    class program
    {
        static void Main(string[] args) 
        {
            int n1=0, n2=2,n3, i, number;
            int Lcm = 0;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}