using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
    abstract class person // abstract class cantnot create object or abstract method does not have body.
    {
        public string first_name;
        public string second_name;
        public int age;//public abstract void show();
        public long phonenumber;

        public abstract void printdetails();
    }
    class student : person
    {
        public int rollno;
        public int fees;

        public override void printdetails()
        {
            string name = this.first_name +" " + this.second_name;
            Console.WriteLine(name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.phonenumber);
            Console.WriteLine(this.rollno);
            Console.WriteLine(this.fees);
        }
    }
    class teacher : person
    {
        public string qualification;
        public int salary;

        public override void printdetails()
        {
            string name = this.first_name + " " + this.second_name;
            Console.WriteLine(name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.phonenumber);
            Console.WriteLine(this.qualification);
            Console.WriteLine(this.salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student alok=new student(); //creating the object for student
            alok.first_name = "alok";
            alok.second_name = "sharma";
            alok.age = 23;
            alok.phonenumber = 111;
            alok.rollno = 123;
            alok.fees = 2000;
            alok.printdetails();

            Console.WriteLine("-=-=-=-==-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            teacher alok1 = new teacher(); // creatinf the object for teacher
            alok1.first_name = "alok";
            alok1.second_name = "sharma";
            alok1.age = 23;
            alok1.phonenumber = 111;
            alok1.qualification = "Bsc cs";
            alok1.salary = 2000;
            alok1.printdetails();
            Console.ReadLine();
        }
    }
}
