using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sorting_W8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var qsArray1 = new[] { 15, 1, 4, 16, 3, 7, 20, 21, 1, 22 };

            var sorter = new quickSorts();
            sorter.quickSort(qsArray1, 0, qsArray1.Length - 1);

            Console.WriteLine(string.Join(", ", qsArray1));
        }
    }
}
