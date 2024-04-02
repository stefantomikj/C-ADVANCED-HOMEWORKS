using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class PrintInConsole
    {
        public static void Print<T>(T item)
        {
            Console.WriteLine(item);
        }


        public static void PrintCollection<T>(List<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
