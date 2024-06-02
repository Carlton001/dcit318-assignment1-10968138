using System;

namespace GradeCalculator
{

    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the marks ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x >= 90)
            {
                Console.WriteLine("A");
            }
            else if (x >= 80 && x <= 89)
            {
                Console.WriteLine("B");
            }
            else if (x >= 70 && x <= 79)
            {
                Console.WriteLine("C");
            }
            else if (x >= 60 && x <= 69)
            {
                Console.WriteLine("D");
            }
            else if (x < 60)
            {
                Console.WriteLine("F");
            }
        }
    }
}