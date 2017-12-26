using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new LiteDatabase(@"C:\Users\mbolshakova\AppData\Local\Application Inspector\Database\patterns");
            var customers = db.GetCollectionNames();

            foreach (var VARIABLE in customers)
            {
                Console.WriteLine(VARIABLE);
            }


        }
    }
}
