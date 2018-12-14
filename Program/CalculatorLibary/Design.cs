using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary
{
    public class Design
    {
        public static void FrameLeft(string mystring)
        {
            Console.WriteLine("| "+mystring.PadLeft(10, ' '));
        }

        public static void Padding(string mystring)
        {
            Console.WriteLine("  |  " + mystring.PadRight(22, ' ') + "|");
        }

        public void FrameRight(string mystring)
        {
            Console.WriteLine(mystring.PadRight(28, '|'));
        }
    }
}
