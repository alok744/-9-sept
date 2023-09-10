using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IEmployee
    {
        void show();
    }
    class partimeEmployees : IEmployee
    {
        public void show()
        {
            Console.WriteLine("this is a method on IEmployee interface");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            partimeEmployees ptr=new partimeEmployees();
            ptr.show();
            Console.ReadLine();
        }
    }
}
