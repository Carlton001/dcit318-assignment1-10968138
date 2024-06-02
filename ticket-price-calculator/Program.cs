using System;
using System.Threading.Tasks.Dataflow;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter age: ");
            x = Convert.ToInt32(Console.ReadLine());

            if(x >= 65 || x <= 12){
                Console.WriteLine("Your ticket price is GHC7");
            }
            else{
                Console.WriteLine("your ticket price is GHC10");
            }
        }
    }

}