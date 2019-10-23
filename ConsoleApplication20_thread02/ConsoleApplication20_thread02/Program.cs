using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//Use of Thread Join 

namespace ConsoleApplication20_thread02
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread oThread = new Thread(MethodJoin);
            oThread.Start();
            oThread.Join();
            Console.WriteLine("work completed..!");
        }
        static void MethodJoin()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("work is in progress..!");

            }

        }
    }
}
