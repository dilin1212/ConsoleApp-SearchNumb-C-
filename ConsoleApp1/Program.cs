using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class myArray
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int a = 60;
            
            Console.WriteLine("Search value of a is: {0}", a);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                if (numbers[i] == a)
                {
                    Console.WriteLine("THE VALUE OF a is FOUND");
                }
                else
                {
                    Console.WriteLine("The value a not found" );
                }
            }
            
            Console.ReadLine();
        }
    }
}
