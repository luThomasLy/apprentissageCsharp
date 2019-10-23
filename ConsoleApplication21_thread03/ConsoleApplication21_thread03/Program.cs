using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

//Use of Thread Sleep

namespace ConsoleApplication21_thread03
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stWatch = new Stopwatch();
            stWatch.Start();

            Thread oThread = new Thread(ProcessSleep);
            oThread.Start();
            oThread.Join();

            stWatch.Stop();
            TimeSpan ts = stWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine("TotalTime " + elapsedTime);

            Console.WriteLine("work completed..!");
        }
        static void ProcessSleep()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("work is in progress..!");
                Thread.Sleep(4000); //Sleep for 4 seconds
            }
        }
    }
}
