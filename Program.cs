using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace reverse_string1
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //string name = "hello world";
    //        //char[] reverse=name.ToCharArray();
    //        //Array.Reverse(reverse);
    //        //string revesename=new string(reverse);
    //        //Console.WriteLine(revesename);
    //        //Console.ReadLine();
    //        string name = "Hello Alok";
    //        char[] reverse = name.ToCharArray();
    //        Array.Reverse(reverse);
    //        string reversename = new string(reverse);
    //        Console.WriteLine(reversename);
    //        Console.ReadLine();
    //    }
    //         //Console.Write("Enter a string: ");
    //        //string input = Console.ReadLine();

    //        //string reversed = ReverseString(input);

    //        //Console.WriteLine("Reversed string: " + reversed);
    //        //Console.ReadLine();
    //    //}

    //    //static string ReverseString(string str)
    //    //{
    //    //    char[] charArray = str.ToCharArray();
    //    //    Array.Reverse(charArray);
    //    //    return new string(charArray);
    //    //    Console.ReadLine();
    //    //}
        
    //}
    public class reversestring
    {
        static void Main(string[] args)
        {
       
            string name = "helloworld";
            string reverse = "";
            for(int i= name.Length-1;i>=0; i--)
            {
                reverse = reverse + name[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
            //char[] reversest=name.ToCharArray();
            //Array.Reverse(reversest);
            //Console.WriteLine(reversest);
            //Console.ReadKey();
        }


    }
}
