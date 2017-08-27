using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If чет/нечет




            /*Console.WriteLine("Please enter an integer value and press Enter.");

            int input = Int32.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Вы ввели четное число");
            }
            else
            {
                Console.WriteLine("Вы ввели нечетное число");
            }*/
            #endregion

            #region switch Coffe

            //Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
            //Console.Write("Please enter your selection: ");

            //string str = Console.ReadLine();
            //int cost = 0;

            //switch (str)
            //{
            //    case "1":
            //    case "small":
            //        cost += 25;
            //        break;
            //    case "2":
            //    case "medium":
            //        cost += 50;
            //        break;
            //    case "3":
            //    case "large":
            //        cost += 75;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
            //        break;
            //}
            //if (cost != 0)
            //{
            //    Console.WriteLine("Please insert {0} cents.", cost);
            //}
            //Console.WriteLine("Thank you for your business.");

            #endregion

            #region For

            //for (int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine($"Counter is at: {counter}");
            //}

            // Create a nested for loop
            // This sample uses a nested loop to find prime numbers
            // less than 100

            //int outer;
            //int inner;

            //for (outer = 2; outer < 100; outer++)
            //{
            //    for (inner = 2; inner <= (outer / inner); inner++)
            //        if ((outer % inner) == 0) break; // if factor found, not prime
            //    if (inner > (outer / inner))
            //        Console.WriteLine("{0} is prime", outer);
            //}

            #endregion

            #region While and do loop

            //int n = 1;
            //while (n < 6)
            //{
            //    Console.WriteLine($"Current value of n is {n}");
            //    n++;
            //}

            //int x = 0;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (x < 5);


            #endregion

            #region MOD2_homework_chess

            string x = "X";
            string o = "O";
            int q = 1;
            int w = 1;

            //for (int i = 0; i < 8; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(String.Concat(Enumerable.Range(0, 4).Select( r => x+o)));
                    
            //    }
            //    Console.WriteLine(String.Concat(Enumerable.Range(0, 4).Select(r => o+x)));
                
            //}

            Console.WriteLine("Another one: ");

            for (int i = 1; i <= 8; i++)
            {
                
                if (i % 2 == 0)
                {
                    while (q <= 4)
                    {
                        Console.Write(o + x);
                        q++;
                    }
                    
                }

                else
                {
                    while (q <= 4)
                    {
                        Console.Write(x + o);
                        q++;
                    }
                }
               

            }



            #endregion
        }
    }
}
