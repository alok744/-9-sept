using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    internal class Program
    {
        interface interface1
        {
            //method having only declaration
            //not defination
            void show();
        }
        class myclass:interface1
        {
            public void show()
            {
                Console.WriteLine("welcome to c sharp world!!!");
            }
            
        }
        // main method
        static void Main(string[] args)
        {
            //creating obj
            myclass obj1=new myclass();
            //cretating method
            obj1.show();
            Console.ReadLine();
        }
    }
}
