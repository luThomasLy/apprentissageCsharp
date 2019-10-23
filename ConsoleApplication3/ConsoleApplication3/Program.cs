using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int compteur = 0;
            while (i < 10)
            {
                compteur++;
                Console.WriteLine(compteur);
                i++;
            }
        }
    }
}
