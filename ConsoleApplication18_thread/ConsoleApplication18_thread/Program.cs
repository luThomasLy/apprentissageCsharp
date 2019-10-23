using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication18_thread
{
    //https://www.youtube.com/watch?v=2_nV7xMvTqg
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            Thread one = new Thread(MyMethod);
            one.Name = "One";
            Thread two = new Thread(MyMethod);
            two.Name = "Two";
            one.Start();
            two.Start();
            Console.ReadLine();
        }

        static void MyMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                i++;
                Thread.Sleep(1000);
            }
        }
    }
}
