using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_contents_of_two_variables_without_a_third
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 7;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
