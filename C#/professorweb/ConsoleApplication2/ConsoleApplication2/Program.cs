using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = "12/14/2017 11:11:39 PM";
            const string format = "MM/dd/yyyy h:mm:ss tt";
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            var resultdate =
                (System.DateTime.ParseExact(date, format, CultureInfo.CreateSpecificCulture("en-US"))).ToString(
                    "MMMM dd yyyy h:mm:ss tt");

            Console.WriteLine(resultdate);
            Console.ReadKey();
                
        }
    }
}
