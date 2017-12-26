using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Используем перенос строки
            Console.WriteLine("Первая строка\nВторая строка\nТретья строка\n");

            // Используем вертикальную табуляцию
            Console.WriteLine("Первый столбец \v Второй столбец \v Третий столбец \n");

            // Используем горизонтальную табуляцию
            Console.WriteLine("One\tTwo\tThree");
            Console.WriteLine("Four\tFive\tSix\n");

            //Вставляем кавычки
            Console.WriteLine("\"Зачем?\", - спросил он");

            Console.ReadLine();
        }
    }
}
