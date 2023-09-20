using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method1
{
    internal class Program
    {
        public abstract class alok //abstract class
        {
            public abstract void alok1();//abstract method;
        }

        public class sudeep : alok
        {
            public override void alok1()
            {
                Console.WriteLine("hello ki halchal");
            }
        }
        public class sudeep1:alok
        {
            public override void alok1()
            {
                Console.WriteLine("hello bachho"); 
            }
        }
        //main method
        static void Main(string[] args)
        {
            //'obj' is object of class 
            // alok is class
            ////instantiate class 'alok'
            alok obj;
            obj =new sudeep();
            

            //instantiate class 'alok1'
            obj = new sudeep1();
            //call 'gfg1()' of class 'g2'
            obj.alok1();
            Console.ReadLine();
        }
    }
}
