using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11_cast
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversion implicite
            int num = 1212;
            long bignum = num;

            //conversion explicite
            float fl = 10.50F;
            int myInt = (int)fl;
            Console.WriteLine(fl);
            Console.WriteLine(myInt);

            //test de la méthode TryParse
            int parsedInt;
            if(int.TryParse("1234",out parsedInt))
            {
                Console.WriteLine("ok, c'est groot");
            }
            else
            {
                Console.WriteLine("ok, ce n'est pas groot");
            }

            //test de la méthode TryParse avec try/catch
            int parsInt;
            try
            {
                parsInt = int.Parse("1234");
                Console.WriteLine(parsInt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("erreur : ", ex.Message);
            }
        }
    }
}
