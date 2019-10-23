using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication2
{
    class Program
    {
        enum Weather
        {
            unknow,
            sunny,
            cloudy,
            rainy,
        }
        static void Main(string[] args)
        {
        Weather todaysWheather = Weather.cloudy;

        Console.WriteLine(todaysWheather);
        }
    }
}

