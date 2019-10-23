using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//Use of Thread Join 

namespace ConsoleApplication19_thread01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Work1();
            //Work2();

            Thread onethread = new Thread(Work1);
            Thread twothread = new Thread(Work2);

            onethread.Start();
            twothread.Start();
        }
        static void Work1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Work 1 is called " + i.ToString());
            }
        }

        static void Work2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Work 2 is called " + i.ToString());
            }
        }
    }
}
