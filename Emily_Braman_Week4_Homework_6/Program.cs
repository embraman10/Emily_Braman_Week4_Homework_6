using System;

namespace Emily_Braman_Week4_Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Given number is even");
            else
                Console.WriteLine("Given number is odd");
            Console.ReadKey();
        }
    }
}
