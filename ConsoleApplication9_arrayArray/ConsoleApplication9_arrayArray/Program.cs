using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9_arrayArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myIntArray = new int[2][];
            myIntArray[0] = new int[5];
            myIntArray[1] = new int[3];
            myIntArray[0][1] = 42;
            myIntArray[1][0] = 30;
        }
    }
}
