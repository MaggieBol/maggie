using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СоставноеПрисваивание
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составные операторы присваивания записываются более кратко, 
            //чем их несоставные эквиваленты. Поэтому их иногда еще называют укороченными операторами присваивания.

            int x = 10;
            x = x + 1;
            // Можно переписать следующим образом
            x += 1;
            x -= 1;
            x *= 1;
            x /= 1;
            x %= 1;
            x |= 1;
            x ^= 1;




        }
    }
}
