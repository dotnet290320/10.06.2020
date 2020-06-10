using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // code snippet

            // this is a one line comment

            /*
             * many
             * lines
             * comment ...
             * */
            Console.WriteLine("Hello world!");
            Console.WriteLine();

            /*
             * int float double
               functions
               parse to int
               parse in function loop
               global variables
               const
               debug - locals, F10, F11
               release\debug
               main args?
               $

               if if-else
               switch-case
               while, do-while, for -- why while + do-while?
               break-continue
               readline
               writeline
               jagged-matrix
               */

            int x = 1; // integer
            float f = 1.8f;
            bool flag = true; // conditions
            flag = false;

            bool isEven = true;
            
            //string st1 = "3";
            //st1 = st1 * 2;
            //int.p

            // this will cause the program to explode for illegal input
            //Int32 mispar_from_user = Convert.ToInt32(input_from_keyboard);

            //Int32 mispar_from_user = int.Parse(input_from_keyboard);

            int x1;
            int.TryParse("14aaa", out x1);
            Console.WriteLine(x1);

            // out - guarantee that this function will insert a value to thie variable
            //       let you send un-initialized variables
            Int32 mispar_from_user = 0;
            while (true)
            {
                Console.WriteLine("Please enter a valid integer number:");
                string input_from_keyboard = Console.ReadLine();
                bool did_you_succeed = int.TryParse(input_from_keyboard, out mispar_from_user);

                //Console.WriteLine(mispar_from_user);

                if (did_you_succeed)
                {
                    Console.WriteLine("You wrote correctly");
                    Console.WriteLine($"{mispar_from_user} is a valid integer!");
                    break;
                }
            }

            for (int i = 1; i < 10; i++)
            {
                //
                //
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
                
                //
                //
            }



            //if (did_you_succeed)
            //{
            //    Console.WriteLine("the number was correctly converted from string to int");
            //}
            //else
            //{
            //    Console.WriteLine("the number was NOT correctly converted from string to int");
            //}


            // 4 lines
            if (mispar_from_user % 2 == 0)
                isEven = true;
            else
                isEven = false;
            // same, but in 1 line!
            isEven = mispar_from_user % 2 == 0;

            if (isEven) // isEven == false --> !isEven // isEven == true // 9 % 2 == 1, 8 % 2 == 0
            {
                //Console.WriteLine("The user entered " + mispar_from_user + " which is an even number");
                Console.WriteLine($"The user entered {mispar_from_user} which is an even number");
                Console.WriteLine($"x = {x} and f = {f} .... ");
            }
            else
            {
                Console.WriteLine($"The user entered {mispar_from_user} which is an odd number");
            }

            Console.WriteLine("Good bye ...");
            Console.ReadLine();
        }
    }
}
