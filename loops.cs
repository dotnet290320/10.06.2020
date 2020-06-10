using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {

        static int GetNumberFromUser(string message)
        {
            int x;
            while (true)
            {
                Console.WriteLine(message);

                string input_from_keyboard = Console.ReadLine();

                bool did_you_succeed = int.TryParse(input_from_keyboard, out x);

                if (did_you_succeed)
                {
                    break;
                }
            }

            return x;
        }

        static void Main(string[] args)
        {

            // while 
            // do-while
            // for - running on range of known numbers 

            int i = 0; // 1
            while (i < 100) // 2
            {
                Console.WriteLine(i);
                i++; // 3
            }

            for ( i = 0; i < 100; i = i + 1)
            {
                Console.WriteLine(i);
            }

            int z = GetNumberFromUser("Enter z:");

            Console.WriteLine("....");

            while (z < 0)
            {
                Console.WriteLine("Z cannot be negative");
                z = GetNumberFromUser("Enter z:");
            }

            int x;
            int y;

            do
            {
                x = GetNumberFromUser("Enter x:");
                y = GetNumberFromUser("Enter y:");
            }
            while (x + y < 200);

                Console.WriteLine("Good bye ...");
            Console.ReadLine();
        }


    }
}
