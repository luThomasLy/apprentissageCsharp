using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 100;
            int myOtherInt = myInt;
            Console.WriteLine("myInt = " + myInt);
            Console.WriteLine("myOtherInt = " + myOtherInt);

            myOtherInt = 5;
            Console.WriteLine("myInt = " + myInt);
            Console.WriteLine("myOtherInt = " + myOtherInt);

        }
    }
}
