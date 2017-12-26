using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            short d = 10, f = 12;
            bool var1 = true, var2 = false;

            if (d < f)
                Console.WriteLine("d < f");
            if (d <= f)
                Console.WriteLine("d <= f");
            if (d != f)
                Console.WriteLine("d != f");

            // Следующее условие не выполнится
            if (d > f)
                Console.WriteLine("d > f");

            // Сравниванием переменные var1 и var2
            if (var1 & var2)
                Console.WriteLine("Данный текст не выведется");
            if (!(var1 & var2))
                Console.WriteLine("!(var1 & var2) = true");
            if (var1 | var2)
                Console.WriteLine("var1 | var2 = true");
            if (var1 ^ var2)
                Console.WriteLine("var1 ^ var2 = true");

            Console.ReadLine();
        }

    }
}

