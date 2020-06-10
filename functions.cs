using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {

        static void PrintHello()
        {
            Console.WriteLine("Hello!");
        }

        static void PrintSum(int x=100, int y=9)
        {
            y = y * 1000;
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        static int Sum(int x, int y)
        {
            int sum_of_x_y = x + y;
            return sum_of_x_y;
        }

        /// <summary>
        /// Finds the biggest number of a pair of numbers
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y12">second number</param>
        /// <returns>the biggest number</returns>
        static int Biggest(int x, int y12)
        {
            if (x > y12)
            {
                return x;
            }

            return y12;

            //else
            //{
                //return y;
            //}
        }

        /// <summary>
        /// Calculates the absolute diff and average of two numbers
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <param name="diff">result of absolute diff [out]</param>
        /// <param name="avg">result of average [out]</param>
        static void Calc(int x, int y, out int diff, out double avg)
        {
            diff = Math.Abs(x - y);
            avg = (x + y) / 2.0;
        }

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
            // function:
            // some code which has a nice name (caption)
            // the name of the function describes what he does
            // starts with captial letter , each word also begins in capital (Pascal case)
            // why?
            // 1. code repitition
            // 2. explains what the code does
            // 3. utility methods

            // F10 - Step over -- will not go into functions code 
            // F11 - Step into

            int zzz = 1;
            int y12 = 12;
            PrintHello();

            PrintSum(8, 9);

            PrintSum(100); // default value

            PrintSum(y:200); // default value

            int sum1 = Sum(18, 19);
            Console.WriteLine($"Sum of 18 + 19 = {sum1}");

            int big = Biggest(20, y12);
            Console.WriteLine($"Bigger is {big}");

            int my_diff;
            double my_avg;
            //Calc(2, 3, d)
            Calc(80, 999, out my_diff, out my_avg);
            Console.WriteLine($"ABS |80-999| = {my_diff} AVG = {my_avg}");

            Int32 x = 0;
            x = GetNumberFromUser("Please enter a valid integer number for x :");

            int y = 0;
            y = GetNumberFromUser("Please enter a valid integer number for y :");

            Console.WriteLine($"{x} + {y} = {x + y}");

            int big_x_y = Biggest(x, y);
            if (big_x_y == x)
                Console.WriteLine($"{x} >= {y}");
            else
                Console.WriteLine($"{y} >= {x}");

            Console.WriteLine("Good bye ...");
            Console.ReadLine();
        }


    }
}
