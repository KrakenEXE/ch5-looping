using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInts
{
    class SumInts
    {
        static void Main(string[] args)
        {
            double userinput;
            double total = 0;
            const double exitVariable = 999;

            Console.WriteLine("Enter number to add:  ");
            userinput = Convert.ToDouble(Console.ReadLine());

            while (userinput != exitVariable)
            {
                total += userinput;
                Console.WriteLine("Enter next amount, or " + exitVariable + " to sum it up ");
                userinput = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Your total is {0}", total.ToString());
            Console.WriteLine("Click enter to exit...");
            Console.ReadLine();
        }
    }
}
