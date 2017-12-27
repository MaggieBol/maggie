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
            chet(16);
            provChet(8);
            nechet(16);

            Console.ReadLine();
        }

        // Метод, преобразующий все нечетные числа в четные
        // в диапазоне [0, x] c помощью 
        // поразрядного оператора &
        static void chet(int x)
        {
            int result;
            Console.WriteLine("Преобразованный диапазон чисел от 0 до {0}:\n", x);
            for (int i = 0; i <= x; i++)
            {
                // Сбрасываем младший разряд числа, чтобы
                // получить четное число
                /*
                 * При побитовой конъюнкции если хотя бы один бит равен 0 итоговый бит тоже равен 0. Поэтому в итоге у num-результата 
                 * все биты кроме младшего не изменяются, а младший становится равным 0.

                Т.е. если число нечетное:
                1001 (9) &
                1110 (0xFFFE)
                ---------------- =
                1010 (8)

                 */
                result = i & 0xFFFE;
                Console.Write("{0}\t", result);
            }
        }

        // Метод, проверяющий является ли число четным
        static void provChet(int x)
        {
            Console.WriteLine("\n\nПроверка четности чисел в диапазоне от 1 до {0}\n", x);
            for (int i = 1; i <= x; i++)
            {
                if ((i & 1) == 0)
                    Console.WriteLine("Число {0} - является четным", i);
                else
                    Console.WriteLine("Число {0} - является нечетным", i);
            }
        }

        // Метод, преобразующий четные числа в нечетные
        // с помощью поразрядного оператора |
        static void nechet(int x)
        {
            int result;
            Console.WriteLine("\nПреобразованный диапазон чисел от 0 до {0}:\n", x);
            for (int i = 0; i <= x; i++)
            {
                result = i | 1;
                Console.Write("{0}\t", result);
            }
        }

    }
}

