//namespace Recursion
//{
//    class program
//    {
//        int num = 5;
//        int result = 1;
//        int factorial() 
//        {
//            if(num == 0)
//            {
//                return 1;
//            }
//            result = result * num;
//            num--;
//            factorial();
//            return result;
//        }

//        static void Main(string[] args) 
//        {                      
//            program obj = new program();
//            int factorial=obj.factorial();
//            Console.WriteLine("Factorial is:"+factorial);
//            Console.ReadKey();
//        }
//    }
//}
namespace Recursion
{
    class program
    {
        static void Main(string[] args)
        {
            int i;
            int num = 4;
            int result = 1;
            for (i = 1; i<= num; i++)
            {
                result = result * i;
             
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}